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





    
    
    