Documentation Notes concerning configuerinig the vagrant file

  # The most common configuration options are documented and commented below.
  # For a complete reference, please see the online documentation at
  # https://docs.vagrantup.com.
  
  # Create a private network, which allows host-only access to the machine using a specific IP.
   config.vm.network "private_network", ip: "192.168.56.102"
   
   
  #Automatically there wil be a shared folder from where your Vagrantfile is located on the hostmachine, to "C:\vagrant"
  
  # Share an additional folder to the guest VM. The first argument is
  # the path on the host to the actual folder. The second argument is
  # the path on the guest to mount the folder. And the optional third
  # argument is a set of non-required options.
  # config.vm.synced_folder "../data", "/vagrant_data"
  
  
  #Provisioning: Use an external script that needs to be executed upon launching the Virtual machine
  #More information can be found at: https://www.vagrantup.com/docs/provisioning/shell.html
  #The parameter privileged is set to true, to make sure the script can be executed by the right credentials
  config.vm.provision "shell", path: "Setup_WISA_script.ps1", privileged: true
  
  
  
  Provisioners are run in three cases: the initial vagrant up, vagrant provision, and vagrant reload --provision.

    A --no-provision flag can be passed to up and reload if you do not want to run provisioners. Likewise, you can pass --provision to force provisioning.

    The --provision-with flag can be used if you only want to run a specific provisioner if you have multiple provisioners specified. For example, if you have a shell and Puppet provisioner and only want to run the shell one, you can do vagrant provision --provision-with shell. The arguments to --provision-with can be the provisioner type (such as "shell") or the provisioner name (such as "bootstrap" from above).
    
  For Example: $ vagrant reload --provision
  !!Without it, the script won't be executed after it's first initialization.
  
  
  Documentation Notes concerning vagrant commands
  
  #To give a list with all the available commands in the vagrant tool
$ vagrant list-commands 

The most important ones that will be used the most are:
$ vagrant init -> initializes a new Vagrant environment by creating a Vagrantfile (where further configurations can be made)
$ vagrant halt -> stops the vagrant machine
$ vagrant reload -> realoads the vagrant machine
$ vagrant up -> starts and provisions the target environment
$ vagrant ssh -> connects to the machine via SSH (For UNIX based OS, for Windows it's better to use PuTTY)
$ vagrant package -> packages a running vagrant environment into a box

Documentation Notes for using Putty to connect to Vagrant Box

1. Run "vagrant ssh-config" in your Project Folder to locate where your Identityfile (public_key) is.
Notice:
$HOSTNAME
$PORT
$LOGINNAME
2. Open the PuTTYgen utility;
3. Click on the `Load` button;
4. open the Identityfile (it doesn't have an extension and that's fine with PuTTYgen)
5. Toward the bottom of the PuTTYgen dialog box, change the value in the `Number of bits in a generated key:` field to `2048`, RSA is fine
6. Save the file (use a $NEW name and the .ppk extension).

Category | Sub-category | Field | Value
--- | --- | --- | ---
Session | | **Host Name:** | $HOSTNAME
| | | **Port:** | $PORT
| | | **Connection type:** | SSH
| Connection | Data | **Auto-login username:** | $LOGINNAME
| Connection/SSH | Auth | **Private key file for authentication:** | Click on the `Browse` button and find the `$NEW.ppk` private key you just converted
| Session | | **Saved Sessions** | vagrant (and then click the `Save` button for the `Load, save or delete a stored session` area)


Documentation notes regarding SQL:
Websites used:
#Creating and running a sql-script:
https://docs.microsoft.com/en-us/sql/relational-databases/scripting/sqlcmd-run-transact-sql-script-files

#Granting Permissions in SQL Server
https://docs.microsoft.com/en-us/sql/t-sql/statements/grant-database-permissions-transact-sql

##Documentation Installing WISA-stack
    
Installing the SQL Database:

This is the official site from where both the mandatory and optional parameters are listed that can be added to the execution of the installer.

https://docs.microsoft.com/nl-nl/sql/database-engine/install-windows/install-sql-server-from-the-command-prompt
Parameters that are relevant to change for the client can be found under the 'required' section: for example
    -SQLSVCACCOUNT
    -SQLSVCPASSWORD
    -AGTSVCACCOUNT
    -etc.

##This site explaines how adding the '/ConfigurationFile=MyConfigurationFile.INI' parameter to the execution of the setup, enables the installation using a configuration file.
https://docs.microsoft.com/en-us/sql/database-engine/install-windows/install-sql-server-using-a-configuration-file
    

Appendix:
    
##Gathering the CONFIG FILE:
http://powershell365.com/2016/01/21/installing-sql-2014-using-configuration-file/

Go through the normal SQL 2014 setup process to select what are the SQL components to be installed and Stop at “Ready To Install” 
Get the configuration file from
C:\Program Files (x86)\Microsoft SQL Server\120\Setup Bootstrap\Log\20160122_022542\ConfigurationFile.ini

SQL2014-Install-01

Modify the following value and save the configurationfile.ini to c:\temp
Change “QUIETSIMPLE” = “False” to “True”
Remove “UIMODE” = “Normal” by adding ;
SQLSVCACCOUNT=”MonsterBean\sqladmin”
SQLSVCPASSWORD=”password” – specify the password 
AGTSVCACCOUNT=”MonsterBean\sqladmin”
AGTSVCPASSWORD=”password” – specify the password 



##Configuring the Windows Server 2008, 2012/R2 and 2016 Firewall to Open Ports for Parallels Remote Application Server Solutions (RAS)
https://www.parallels.com/blogs/ras/configuring-the-windows-server-2008-r2-firewall-to-open-ports-for-2x-solutions/


##Enable Ping on Windows Server 2016
https://www.rootusers.com/how-to-enable-ping-in-windows-server-2016-firewall/


##Uninstalling SQL:
setup.exe /Action=Uninstall /FEATURES=SQL,AS,RS,IS,Tools /INSTANCENAME=MSSQLSERVER Or via configfile: 
setup.exe /Action=Uninstall /configurationfile="../configurationfile.ini"

Documentations notes regarding installation Webplatforminstaller

1. Install WebplatformInstaller:
  mkdir c:\webdeployv2 -Force
    (New-Object Net.WebClient).DownloadFile('https://download.microsoft.com/download/C/F/F/CFF3A0B8-99D4-41A2-AE1A-496C08BEB904/WebPlatformInstaller_amd64_en-US.msi','C:\webdeployv2\WebPlatformInstalleramd64_en-US.msi')
    
    msiexec /i "C:\webdeploy\WebPlatformInstaller_amd64_en-US.msi" /qr
    
2.  Run to see all the available products to install:
"C:\Program Files\Microsoft\Web Platform Installer\WebPICMD-x64.exe" /List /ListOption:all

3.  To install use parameters /Install /Products:"..."
for example: WebPICMD-x64.exe/Install /Products:MVC3,WebMatrix OR in powershell WebPICMD-x64.exe/Install /Products:"MVC3,WebMatrix"

Further information can be found at: https://docs.microsoft.com/en-us/iis/install/web-platform-installer/web-platform-installer-v4-command-line-webpicmdexe-rtw-release