Write-Host "... Installing IIS...."
Install-WindowsFeature -Name Web-Server, Web-Mgmt-Tools, Web-Security
Write-Host "IIS installed"
Write-Host "... Installing ASP.NET...."
Install-WindowsFeature NET-Framework-45-ASPNET ;
Write-Host "ASP.NET installed";
Write-Host "Installing sql Server";
#installSQLServer
#/QUIETSIMPLE

$Password = "MyP@ssw0rd" ;
$instanceName = "SQLEXPRESS";
$InstanceId = "SQLEXPRESS";
$User = "sqlsvr12ex";


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
        C:\tempsql\SQLEXPRWT_x64_ENU\setup.exe /ACTION=Install /FEATURES=SQL /INSTANCENAME=MSSQLSERVER /HIDECONSOLE /INDICATEPROGRESS="True" /IAcceptSQLServerLicenseTerms /SQLSVCACCOUNT="NT AUTHORITY\NETWORK SERVICE" /SQLSYSADMINACCOUNTS="builtin\administrators" /SKIPRULES="RebootRequiredCheck"; #/INSTANCEID=$($InstanceId) /SQLSVCACCOUNT="$($User)" /SQLSVCPASSW0RD="$($password)";
        $env:PATH = [System.Environment]::GetEnvironmentVariable("Path","Machine")
        #Remove-Item -Recurse -Force c:\tempsql
    } else {
        Write-Output "SQL Server 2014 Express already installed"
    }
    