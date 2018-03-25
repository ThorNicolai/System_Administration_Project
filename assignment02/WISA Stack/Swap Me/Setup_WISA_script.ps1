Write-Host "Installing sql Server";

       if (-not (Test-Path "C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS")) {
        if (-not (Test-Path "C:\tempsql\SQLEXPRWT_x64_ENU.exe")) {
            Write-Output "Downloading SQL Server 2014 Express"
            mkdir c:\tempsql -Force
            (New-Object Net.WebClient).DownloadFile('http://download.microsoft.com/download/E/A/E/EAE6F7FC-767A-4038-A954-49B8B05D04EB/ExpressAndTools%2064BIT/SQLEXPRWT_x64_ENU.exe','C:\tempsql\SQLEXPRWT_x64_ENU.exe')
        }
        Write-Output "Unpacking SQL Server 2014 Express"
        C:\tempsql\SQLEXPRWT_x64_ENU.exe /x:"c:\tempsql\SQLEXPRWT_x64_ENU" /u | Out-Null
        Write-Output "Adding .NET 3.5"
        Import-Module Servermanager
        Add-WindowsFeature NET-Framework-Core
        Write-Output "Installing SQL Server 2014 Express"
        #Use to create a normal config file:
        #C:\tempsql\SQLEXPRWT_x64_ENU\setup.exe /ACTION=Install /FEATURES=SQL /INSTANCENAME=MSSQLSERVER /HIDECONSOLE /INDICATEPROGRESS="True" /IAcceptSQLServerLicenseTerms /SQLSVCACCOUNT="NT AUTHORITY\NETWORK SERVICE" /SQLSYSADMINACCOUNTS="builtin\administrators" /SKIPRULES="RebootRequiredCheck"; #/INSTANCEID= "SQLEXPRESS" /SQLSVCACCOUNT="SQLEXPRESS /SQLSVCPASSW0RD="Password1";
        
        #Use to install SQL Server via a configuration file
        C:\tempsql\SQLEXPRWT_x64_ENU\setup.exe /configurationfile="C:\vagrant\configurationfile.ini" /IACCEPTSQLSERVERLICENSETERMS /INDICATEPROGRESS="True"
        
       
        Write-Output "Done installing"


    } 
    else {
        Write-Output "SQL Server 2014 Express already installed"

        #Uninstall SQL SERVER
        #C:\tempsql\SQLEXPRWT_x64_ENU\setup.exe /Action=Uninstall /FEATURES=SQL,AS,RS,IS,Tools /INSTANCENAME=SQLEXPRESS
        #C:\tempsql\SQLEXPRWT_x64_ENU\setup.exe /Action=Uninstall /configurationfile="C:\vagrant\configurationfile.ini"
    }

Write-Host "... Installing IIS...."
Install-WindowsFeature -Name Web-Server, Web-Mgmt-Tools, Web-Security
Set-ExecutionPolicy Bypass -Scope Process

Enable-WindowsOptionalFeature -Online -FeatureName IIS-WebServerRole
Enable-WindowsOptionalFeature -Online -FeatureName IIS-WebServer
Enable-WindowsOptionalFeature -Online -FeatureName IIS-CommonHttpFeatures
Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpErrors
Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpRedirect
Enable-WindowsOptionalFeature -Online -FeatureName IIS-ApplicationDevelopment
Enable-WindowsOptionalFeature -Online -FeatureName IIS-HealthAndDiagnostics
Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpLogging
Enable-WindowsOptionalFeature -Online -FeatureName IIS-LoggingLibraries
Enable-WindowsOptionalFeature -Online -FeatureName IIS-RequestMonitor
Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpTracing
Enable-WindowsOptionalFeature -Online -FeatureName IIS-Security
Enable-WindowsOptionalFeature -Online -FeatureName IIS-RequestFiltering
Enable-WindowsOptionalFeature -Online -FeatureName IIS-Performance
Enable-WindowsOptionalFeature -Online -FeatureName IIS-WebServerManagementTools
Enable-WindowsOptionalFeature -Online -FeatureName IIS-IIS6ManagementCompatibility
Enable-WindowsOptionalFeature -Online -FeatureName IIS-Metabase
Enable-WindowsOptionalFeature -Online -FeatureName IIS-ManagementConsole
Enable-WindowsOptionalFeature -Online -FeatureName IIS-BasicAuthentication
Enable-WindowsOptionalFeature -Online -FeatureName IIS-WindowsAuthentication
Enable-WindowsOptionalFeature -Online -FeatureName IIS-StaticContent
Enable-WindowsOptionalFeature -Online -FeatureName IIS-DefaultDocument
Enable-WindowsOptionalFeature -Online -FeatureName IIS-WebSockets
Enable-WindowsOptionalFeature -Online -FeatureName IIS-ApplicationInit
Enable-WindowsOptionalFeature -Online -FeatureName IIS-ISAPIExtensions
Enable-WindowsOptionalFeature -Online -FeatureName IIS-ISAPIFilter
Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpCompressionStatic

Write-Host "IIS installed"


Write-Host "... Installing ASP.NET...."
Install-WindowsFeature NET-Framework-45-ASPNET ;
Write-Host "ASP.NET installed";


#Install chocolatey packet manager
#Set-ExecutionPolicy Bypass -Scope Process -Force; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))

#Enable ping
Import-Module NetSecurity
New-NetFirewallRule -Name Allow_Ping -DisplayName “Allow Ping”  -Description “Packet Internet Groper ICMPv4” -Protocol ICMPv4 -IcmpType 8 -Enabled True -Profile Any -Action Allow

#Install Web-deploy (for deploying ASP.net testapplication)

Write-Output "Download Web deploy tool"
mkdir c:\webdeployv2 -Force
(New-Object Net.WebClient).DownloadFile('https://download.microsoft.com/download/C/F/F/CFF3A0B8-99D4-41A2-AE1A-496C08BEB904/WebPlatformInstaller_amd64_en-US.msi','C:\webdeployv2\WebPlatformInstaller_amd64_en-US.msi')
msiexec /i "C:\webdeployv2\WebPlatformInstaller_amd64_en-US.msi" /qr

#Korte pauze, zorgt anders voor concurency problemen
Start-Sleep -m 30000

#To list the available options to install
#Start-Process -FilePath "C:\Program Files\Microsoft\Web Platform Installer\WebPICMD-x64.exe" -ArgumentList "/List:All"

Start-Process -FilePath "C:\Program Files\Microsoft\Web Platform Installer\WebPICMD-x64.exe" -ArgumentList "/Install /Products:ASPNET45,WDeploy36PS,IISManagementScriptsAndTools,MVC3 /AcceptEULA"

#Grant Permission to guest to create Database
sqlcmd -S WIN-5RA2OGDHQ4S\SQLEXPRESS -i C:\vagrant\scriptPermission.sql
 
Write-Output "Script Completed"   