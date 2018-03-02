

First assignment: Create test environment with Virtualbox VM’s on platforms:

What they want us to do is create 2 test environments for our "customers". The customers want webapplication hosting. So we have to setup web application servers. LAMP and WISA are used for respectively Linux and Windows for webapplications.

A web application is hosted on a server. CentOS and Windows Server are our servers. The "stacks" are the applications that together form the webapplications.

Apache and IIS are the webservers.
MariaDB and SQLServer are the databases.
PHP & ASP.Net are the web applications.

**LAMP stack**: **L**inux (CentOS 7 of Fedora Server) + **A**pache + **M**ariaDB + **P**HP

**WISA stack**: **W**indows Server 2016 + **I**IS + **S**QLServer (of eventueel MySQL) + **A**SP.NET

Requirements

 - Easily create the test environment with backend
	 -  Drupal for LAMP
	 - Open source ASP.NET application for WISA
	 - **_Drupal and the other thing are our backends. These run on PHP and on ASP.NET respectively. This doesn't mean much more than that the websites are managed and designed with these applications._**
 - Reproducible and automatic installationproces of test environment
 -  Reusability
	 - Scripts useable on different environments:
	 - On the VM and on a public/private cloud platform
	 - **_This just means your scripts can’t be hardcoded completely, when you write them for the VM you will understand_**
 -  Settings for applications are configurable
	 - **_Means don’t set hard coded values, this probably means names of databases, names of webservers and websites etc._**
 - DIVISION between installationscript for platform and for
   webapplication
   - **_This means that you have two separate scripts, one that is completely automatic in configuring the “platform” AKA the OS and a
   script with user input for the web application and stuff_**
  -  1 proof of concept with public cloud platform
	  -  **_We will use DigitalOcean and on that the Linux LAMP webserver. Trust me, this will be the easiest for us (because I will do it since
   I have done it before)_**

Assignment 2: Local SAP-development environment

Install SAP Netweaver ABAP Application Server developer edition on Linux VM in Virtualbox. Automate this installation process & document when it can’t be automated. Also create a guide for developers on how to use this virtual SAP server.

Requirements:

- Proof-of-concept of such a VM
- Installation is where possible automate, and all of it is documented.
- Make the script so that it remains useable in the future when new versions of tools etc are used
- Make a guide for:
	- Technical guide for setting up the development environment
	- User manual for ABAP-developer on how to work with the environment

<!--stackedit_data:
eyJoaXN0b3J5IjpbLTc5MjczMzEzM119
-->
