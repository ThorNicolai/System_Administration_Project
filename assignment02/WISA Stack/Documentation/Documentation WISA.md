User Manual WISA
================

In this document you can find the user manual for both the manual as for
the automatical installation of a WISA-stack and setting up a host for
web deployment.

A: Install WISA-STACK manually
==============================

Step 1: Install Windows Server 2016 ( by using Virtual Box) {#step-1-install-windows-server-2016--by-using-virtual-box}
-----------------------------------------------------------

![](https://gyazo.com/7a2a9d69ffbbc08dacea13d335ffba0c.png)

At the time of writing this, the most recent version of a Windows Server
is Windows Server 2016.

The options that are prompted by virtual box regarding memory size and
hard disk can be left on the default settings. Continue through these
options until your virtual machine has been created.

![](https://i.gyazo.com/c06b1c88a1cfc113d9b9e197ed20d9f0.png)\
 ![](https://i.gyazo.com/3e2d78784c429d6aca653ab63dd1638c.png)

Before starting up the virtual machine it is important to go into the
settings of your virtual machine and under ‘Storage’ chose a virtual
optical disk or physical drive with a ‘Windows Server 2016’ so that upon
booting, Windows Server 2016 can be installed.\
 ![](https://i.gyazo.com/7ef98d9b8f7ba478214cb237fefbdd05.png)

NOTE: Another option is installing is installing the windows server
manually via an installation disk and not necessarily using a virtual
machine. However, in this user manual we will focus on the use of
VirtualBox for the installation process.

Step 2a: Manually install IIS on a Windows Server 2016 Operating System:
------------------------------------------------------------------------

To install the Web Server (IIS) Server Role manually, you can open
‘Server Manager’ and select: ‘Manage’ – ‘Add Roles and Features’

![](https://i.gyazo.com/9052abd5d974511460108b8c76f0f205.png)

Continue the install process until finding yourself on the following
page and select to the Web Server (IIS) Server Role. Continue by
pressing the ‘Add Features’ button.\
 ![](https://i.gyazo.com/c0d0d3326b1d5aba6185c1ba32264451.png)

Afterwards, continue the installation process and finally press the
‘install button’ on the ‘Confirmation’ screen.

![](https://i.gyazo.com/292560a078effba052510ffe28e1ca35.png)

Step 2b: Manually install Microsoft SQLServer (2014) on a Windows Server 2016 Operating System:
-----------------------------------------------------------------------------------------------

Go to the following link to download the 64-bit version of SQL Server
2014 Express:
[http://download.microsoft.com/download/E/A/E/EAE6F7FC-767A-4038-A954-49B8B05D04EB/ExpressAndTools%2064BIT/SQLEXPRWT\_x64\_ENU.exe](http://download.microsoft.com/download/E/A/E/EAE6F7FC-767A-4038-A954-49B8B05D04EB/ExpressAndTools%2064BIT/SQLEXPRWT_x64_ENU.exe)

Upon starting the installer, chose the option: ‘New SQL Server
stand-alone installation or add features to an existing installation’\
 ![](https://i.gyazo.com/5623140a45737c0b8c68940b3cb98794.png)

Continue the installation process until the installer asks for an
instance id: Upon leaving this blank your instance name will be by
default ‘MSSQLEXPRESS’

![](https://i.gyazo.com/b58109dd8c5d1ee2b11a469d54f2e0ca.png)

Finish the installation process and restart your computer for the
installation to complete.

(Any problems with the installation, I forward to the official SQL
Server Forum:
[https://social.msdn.microsoft.com/Forums/sqlserver/en-US/home?forum=sqlexpress](https://social.msdn.microsoft.com/Forums/sqlserver/en-US/home?forum=sqlexpress)
)

Manually install [ASP.NET](http://ASP.NET) on a Windows Server 2016 Operating System:
-------------------------------------------------------------------------------------

To install the .NET Framework 3.5 and 4.6 Features manually, you can
open ‘Server Manager’ and select: ‘Manage’ – ‘Add Roles and Features’

![](https://i.gyazo.com/9052abd5d974511460108b8c76f0f205.png)

Continue the install process until finding yourself on the following
page and the .NET Framework 3.5 and 4.6 Features. Continue by pressing
the ‘Add Features’ button.

![](https://i.gyazo.com/32f0b3cdbc2d3923a9d23bf8a87e15bc.png)

Afterwards, continue the installation process and finally press the
‘install button’ on the ‘Confirmation’ screen.

![](https://i.gyazo.com/53697d3f98cf9e44548b400333ca3a36.png)

NOTE: Right now you should have a fully functional WISA-STACK. To be
sure that everything works you can go to your web browser and enter the
local IP-address of your machine and check the running services in
Windows to see if your SQLservice is running.

Step 3: Manually install the Webdeploy kit for deploying [ASP.NET](http://ASP.NET) applications on a Windows Server 2016 Operating system.
------------------------------------------------------------------------------------------------------------------------------------------

Download the 64-bit installer from the following link:
[https://download.microsoft.com/download/C/F/F/CFF3A0B8-99D4-41A2-AE1A-496C08BEB904/WebPlatformInstaller\_amd64\_en-US.msi](https://download.microsoft.com/download/C/F/F/CFF3A0B8-99D4-41A2-AE1A-496C08BEB904/WebPlatformInstaller_amd64_en-US.msi)

Read and accept the license agreement.\
 ![](https://i.gyazo.com/c977f1bdc173d0bb44a50fddd709b7c2.png)

After the installation of the Web platform Installer, you should run
WebPlatformInstaller5.exe from the designated folder. Here a list can be
found of all the possible features, products and applications that can
be installed. Go to ‘Products’ and search for the following Products
that need to be installed:

-   ASPNET45

-   WDeploy36PS

-   IISManagementScriptsAndTools

-   MVC3

![](https://i.gyazo.com/6834750f1914f9f3277964f5e9275a9e.png)

Afterwards press the install button to install the features.

NOTE: Right now your machine is ready for [ASP.NET](http://ASP.NET)
application to be published on. (For example by using MS Visual Studio)

B: Automatically install WISA STACK and enable web deployment:
==============================================================

1.  Install vagrant:
    [https://www.vagrantup.com/](https://www.vagrantup.com/)

2.  Install Virtualbox:
    [https://www.virtualbox.org/](https://www.virtualbox.org/)

3.  Search for an appropriate “box”. This is a VM.

[https://app.vagrantup.com/boxes/search?utf8=✓&sort=downloads&provider=&q=windows+server+2016](https://app.vagrantup.com/boxes/search?utf8=%E2%9C%93&sort=downloads&provider=&q=windows+server+2016)

For this User Manual the following box has to be used:
DBSowner/ProjectsSysAdm

NOTE: \#OR create your own “box”: more detailed instructions can be foud
here
[https://www.vagrantup.com/docs/virtualbox/boxes.html](https://www.vagrantup.com/docs/virtualbox/boxes.html)

\#a. Set up a virtual machine of the desired Operating System (for
example: Windows server 2016), using virtual box\
 \#b. Use the following command : vagrant package --base %NAME\_VM%
--output %PLACE/TO/PUT/.BOX%CORRECT\
 \#c. Go to: [https://app.vagrantup.com/](https://app.vagrantup.com/),
create an account and a new box.\
 You can upload only ‘.box’ files so make sure the previous step was\
 succesful\
 \#d. Don’t forget to ‘release’ the box on the website so that others
can (including you) can download it from the Hashicorp Servers.

5.  In CMD, go to the folder where you want to use Vagrant. (This can be
    done by going to the desired map and typing ‘powershell’ in the
    navigation-bar on GUI enabled Windows Servers)

6.  Run the command “vagrant init DBSowner/ProjectsSysAdm --box-version
    1.0” (A Vagrantfile should now be created)

\#Custom settings can be made within this file.

!!!To make the testing easier, a reference Vagrantfile is included in
this git-project (in the ‘swap me’-map) and should be swapped with the
one created (as should the other files for testing purposes later in
this document!).

7.  After placing the files from the ‘swap me’-map into the map where
    the original Vagrantfile was located:

Run the command “vagrant up”

The Windows credentials are the following: Administrator - PolPol22

Your VM should now be created and accessible from VirtualBox

(In case there is a problem with starting the vm, use the ‘vagrant up
--provision’ command to make sure the script to install the WISA tries
to run again)

C: Publish an [ASP.NET](http://ASP.NET) application on a Windows Server 2016 Operating system, using Visual studio from another host:
=====================================================================================================================================

In Visual Studio, right click on the application in the solution
explorer and select the “Publish…” option\
 ![](https://i.gyazo.com/01309cc99df0fd1ed215601a9db73d6f.png)

Create new publishing profile: “IIS, FTP, etc”

![](https://i.gyazo.com/130940a749ea0901381bacb6850e2fc4.png)

Enter following settings:

-   Publish method: Web Deploy

-   Server: 192.168.56.103

-   Site name: Default Web Site

-   User name: Administrator

-   Password: PolPol22

-   Destination URL: (keep this field clear)

!!!These settings might differ from yours, depending on what IP-address
your VM-host has and what credentials were given to Windows Server.

Validate connection and press “next”\
 ![](https://i.gyazo.com/6fe87857165525e3551cdcd30ac6a61c.png)

Under Databases you enter the following remote connection string: Data
Source=WIN-5RA2OGDHQ4S\\SQLEXPRESS;Integrated Security=True;Initial
Catalog=Bierhalle;

!!!Again, these settings might be different depending on the host, and
on the application.

D: Appendix
===========

For more information regarding used sources and other tips, you can
search the documentation notes. A broader explanation on the scipt can
be found as comment lines in the script itself (under the swap me folder
of this Git-project).
