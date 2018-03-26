
# Setting up a VM and installing SAP ABAP
## Prerequisites
### Necessary hardware
-   x86_64 Processor based hardware
-   at least 8 GB RAM plus about 8 GB swap space;
-   About 100 GB free disk space for server installation
-   About 2 GB free disk space for client installation
### Downloads
- Latest version of  [Oracle VirtualBox](https://www.virtualbox.org/wiki/Downloads)
- Dvd-image of [openSUSE Leap](https://software.opensuse.org/distributions/leap)
- All relevant [ABAP files](https://store.sap.com/sap/cp/ui/resources/store/html/SolutionDetails.html?pid=0000014493&catID=&pcntry=DE&sap-language=EN&_cp_id=id-1477346420741-0), this requires you to create an account for the SAP Store.

---

### Virtual Machine (VM) installation

In Virtual Box we will create a new VM instance, we will use following values:
- Type: Linux
- Version: openSUSE (64 bit)
- Memory Size: 6GB
- Create a virtual hard disk now (VHD)
- Dynamically allocated (100 GB)

When first starting the VM after creation select the correct .iso file that you downloaded previously for openSUSE Leap. It will have the following format **openSUSE-Leap-42.3-DVD-x86_64.iso** and install this DVD-image.

In the following dialog you will have to **adjust the language and the keyboard layout** settings:
- Language should be English US.
- Keyboard can be your choice.

In the next step **Suggested Partitioning** choose **Edit Proposal  Settings** and follow the image below:

![Edit Proposal Settings](https://blogs.sap.com/wp-content/uploads/2017/08/vBox_B7.png)

Select the correct **Region and Timezone** and opt for the **GNOME** Desktop Selection.

In the next window you can **create a Local User**, fill in the form and create a master password ( at least 7 characters).

## IMPORTANT: In Installation Settings, do not choose Install yet!

Instead scroll down and **disable the Firewall and enable SSH service**.
![Firewall and SSH service](https://blogs.sap.com/wp-content/uploads/2016/11/vBox_6_Firewall_SSH.png)

---
### ABAP preperation
First we will assign a shared folder between our Virtual Machine (VM) and our Local Machine, in Virtual Box Manager select your Linux system and choose **Settings**, go to **Shared folders**
add a new folder by choosing the plus (+) icon. In the dialog that appears, navigate to the folder that contains your previously downloaded ABAP installation files. Change the folder name to **s4installer**. 

![Shared Folder settings](https://blogs.sap.com/wp-content/uploads/2017/09/Shared_Folders.png)
> Reboot the system.

Now go to your terminal and use the following commands to install **uuidd and nano**, *you need the root password for these super user commands*.

	sudo apt-get install uuidd
>Reboot the system and repeat this process for nano

	sudo apt-get install nano

Now start the **uuidd** service using your terminal and the root's password:

	sudo service uuidd start

Change the hostname to *vhcalnplci* by entering:

	sudo nano /etc/hostname
In nano it should look something like this:

![](https://blogs.sap.com/wp-content/uploads/2017/08/vBox_C10_hostname-1.png)

Use **Ctrl + O** and  **Enter** to save.
Quit nano using **Ctrl + X**.

Now restart your network using:

	sudo rcnetwork restart

Now we will **map the IP address** to the new hostname, open the hosts file by entering;

	sudo nano /etc/hosts

In nano add a new entry with the following parameter:

	10.0.2.15 vhcalnplci vhcalnplci.dummy.nodomain
Again use **Ctrl + O** and  **Enter** to save and quit nano using **Ctrl + X**.

For the last step before we install ABAP, we will **assign root privileges** to the install script by using the following commands:

	sudo -i
	ENTER THE ROOT'S PASSWORD
	cd /media/sf_s4installer
	chmod +x install.sh

### Installing ABAP

Still in the *vhcalnplci:/media/sf_s4installer/* directory use the following command:

	./install.sh

### Post-installation settings
In Oracl VirtualBox Manager select your Linux VM then choose **Settings**, from the left hand menu select **Network** open **Advanced** and choose **Port Forwarding**
Somthing like this:

![Portforward settings](https://imgur.com/kivqy4S.png)


Enter the following settings for all the corresponding ports:


![Portworward table](https://i.imgur.com/kkdsVCq.png)


## Your installation should be ready to use and run.
