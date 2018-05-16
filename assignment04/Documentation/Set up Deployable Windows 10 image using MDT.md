# Creating a deployable Windows 10 image in MDT

## Prerequisites

- A Windows Server with all the necessary features is available, click  [here](https://github.com/HoGentTIN/p2ops-i01) for a guide
- Windows ADK & Microsoft Deployment Toolkit is installed on the deployment server
- A clean install *.iso* file from Windows 10 operating system is downloaded on the server
- All the prefered applications are available in .*msi* format to be installed 
		
	>For this image we have Java, LibreOffice and Adobe Reader included

## Create Deployment Share

In **DeploymentWorknbench** you will see an empty folder for Deployment Shares, for starters we need to *right click* and **create a new Deployment Share.**

Now in the **Wizard** of the new Deployment Share we can **use all the defaults** for creating it.

Once the Wizard has ended your Deployment Share is ready to be configured.

## Import Operating System

First step to deploying your custom Installation is by importing your Operating System (OS).

In the Deployment Share folder in DeploymentWorkbench we can now see a folder structure and one of those folders is **Operating Systems**. 
Before we can import a new OS we need to mount it in Windows Explorer as such:

![Mount .iso](https://i.imgur.com/8dc1G0y.png)

A correctly mounted OS should look something like this:

![Mounted os](https://i.imgur.com/Q3CLCA1.png)

In **DeploymentWorkbench**, *right click* the OS folder and **Import Operating System**.
- Choose *Full set of source files*, press Next.
- Browse to the Mounted DVD-station, press Next.

The OS Wizard will detect the Operating System and now you can just press Next till the Wizard is finished.

## Include Applications

In **DeploymentWorkbench**, *Right click* your Applications folder and choose **New Application**

- Choose *Application with source files*, press Next.
- Specify the details as you prefer, press Next.
- Browse to the Application.msi folder, press Next.
- Specify the Directory name, press Next.
- Insert the right command for a prefered installation method (quiet install) all the parameters for msiexec can be shown by going to your cmd and running *msiexec*
	
		msiexec /i c:\path\to\package.msi /quiet /qn /norestart
	-	An installation log can be added by implementing: 
		
			/log c:\path\to\install.log

- Finish the Wizard and the Application should be available in the **Application Folder**.

Repeat this step for every application you would like to implement.

## Task Sequences

In **DeploymentWorkbench**, *Right click* your Task Sequences folder and choose **New Task Sequence**

- Give the Task Sequence (TS) a relevant ID and name, press Next.
- In the next step we can Select a Template, for this easy installation we are just going to use the default **Standard Client Task Sequence**, press Next.
- Choose your OS, press Next.
- Do not specify a product key, press Next.
- Enter name and organisation, press Next.
- Configure the admin password, this can be changed later, press Next.
- Finish the TS Wizard.

## Deployment Share Properties

### Rules

Go to **properties** of the Deployment Share and in the **Rules tab** you can add specific rules to skip steps when installing the OS.
Our used rules can be found  [here](https://github.com/HoGentTIN/p2ops-i01/blob/master/assignment04/MDT%20Deployment%20Share%20Rules.md)

### Update
Since it is our first time using this Deployment Share we need to generate our boot files using the Deployment share we just created. *Right click* the deployment share and press **Update Deployment Share**.

In this wizard we select **Completely regenerate the boot images** and finish the wizard by pressing Next twice and Finish.
