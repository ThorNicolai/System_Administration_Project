# Assignment 2: Automating server set-up

## Job description: web application servers

Several customers ask us to host their **web application**. Until now, we have always manually set up a server with the necessary software installed and configured. Due to the growing demand, this is not sustainable. An improvement would be to work out a kind of "template" which deploys a new server automatically, and which is immediately configured to run the needed application(s). To make it easier for a web application developer to set up a **test environment** on her / his own laptop, the first step is to create VirtualBox VMs.

We initially provide the following platforms:

- **LAMP stack**: **L**inux (CentOS 7 or Fedora Server) + **A**pache + **M**ariaDB + **P**HP
- **WISA stack**: **W**indows Server 2016 + **I**IS + **S**QLServer (or possiby MySQL) + **A**SP.NET

You should be able to set up servers with *the exact same* configuration in a **production environment**. However, we are not sure yet whether we will set up and maintain the necessary infrastructure ourselves (*private cloud*), or will outsource this to an Infrastructure as a Service provider (*public cloud*). Public cloud providers we are considering are [Digital Ocean] (https://www.digitalocean.com/) (50$ credits available through [Github Student Pack] (https://education.github.com/pack)), or [Amazon Web Services] (https://aws.amazon.com/s/dm/landing-page/start-your-free-trial/) (12 month free trial, but a credit card is needed on activation).

### Acceptance criteria

- An application developer should easily be able to deploy a test environment for running a web application with database back-end.
	- You demonstrate this by giving a demo of a web application running on the platform (e.g. Drupal on LAMP, or an [open source ASP.NET application] (https://www.codeproject.com/Tips/667263/ ASP-NET-Open-Source-Projects) on WISA)
- Setting up these servers must **be exactly reproducible**. To be truly scalable, you have to automate the entire installation process. This can be done by using an automation tool such as [Vagrant] (http://vagrantup.com/), combined with a installation script (Bash, PowerShell).
- The necessary attention has been paid to re-usability.
	- The scripts can be used on different types of systems: within the VirtualBox test environment on your desktop, within one of the proposed public / private cloud platforms.
	- Application specific settings (e.g. initialisation of the database, installation of the application on the server) are configurable. So avoid "hard-coded" data between the code, but use variables wherever possible.
	- Make a distinction between the installation script for the *platform* (which is reusable) and the web application itself (determined by the user)
- A proof-of-concept has been set up with a public cloud platform (either from the specified providers / products or another one after agreement with the tutors) for at least one of the types of application servers.


## Job description: Local SAP development environment

We also received a question from a team of SAP developers. SAP is a so-called Enterprise Resource Planning system that allows administrative business processes to be automated. The current situation is that they work on a central SAP server as a development environment, but there are various practical and organisational problems with this situation. The available server is under-dimensioned, so that it often fails if too much activity takes place. Moreover, this type of installation is subject to the licensing conditions of SAP and in order to save costs they are looking for an alternative.

A possible approach would be the * developer edition * of [SAP NetWeaver] (https://en.wikipedia.org/wiki/SAP_NetWeaver) ABAP [Application Server] (https://en.wikipedia.org/wiki/SAP_NetWeaver_Application_Server ) on a Linux VM in VirtualBox so that developers can set up a local development environment without having to depend on the current server over the network.

Your job is to perform this installation, where possible to automate it or if not to document it thoroughly. You also provide a manual for the developers how they can get started with this virtual SAP server.

More information:

- <https://blogs.sap.com/2017/09/04/newbies-guide-installing-abap-as-751-sp02-on-linux/>
- <http://www.sapyard.com/minisap-installation-part-1/>
- <https://blogs.sap.com/2013/05/16/developer-trial-editions-sap-netweaver-application-server-abap-and-sap-business-warehouse-powered-by-sap-hana/>
- <https://tools.hana.ondemand.com/#abap>

### Acceptance criteria

- There is a proof-of-concept of an SAP NetWeaver development environment in VirtualBox
- The installation is automated where possible, and in any case documented. In the installation script and documentation you should focus on how this environment can be reproduced in the future (with new versions of the tools used).
- Provide manuals:
	- on the one hand a technical manual for setting up the development environment,
	- on the other hand, a user manual for an ABAP developer who wants to start working with this environment


## Deliverables

Demo during the contact moments of:

- Test environment with VirtualBox for all requested platforms:
	- Show how the VMs can be initialised.
	- Show how a web application can be installed on the VM (using a web application with a database back-end) and how an ABAP developer can work with the SAP environment
- Proof-of-concept with a public cloud platform from one of the web application servers, initialised with the same installation script as the test environment.

On Github:

- Tender
- All background information that you have collected in order to get started with this assignment
- Detailed technical manuals directed to other team members about installation procedures and the used scripts
- User's guide (i.e. web application or SAP developer)
- Test plans and test reports
