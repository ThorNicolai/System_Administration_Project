# Automated Setup VM and SAP ABAP installation
## Introduction

This guide will help you setup a VirtualBox instance with Vagrant to install *SAP NetWeaver AS ABAP 750 SP02 Developer Edition*.

All recommended system preparations will be done by packer and vagrant, as described at [Installing ABAP AS on Oracle VirtualBox]([https://blogs.sap.com/2016/11/03/linux-for-newbies-installing-opensuse-on-oracle-virtualbox/?preview_id=391946](https://l.facebook.com/l.php?u=https%3A%2F%2Fblogs.sap.com%2F2016%2F11%2F03%2Flinux-for-newbies-installing-opensuse-on-oracle-virtualbox%2F%3Fpreview_id%3D391946&h=ATNtSwKt-pZmWmxyvIZ-SUQY5Ko9xHeK8OVqboHkKBoKBgRAAYXEzg-VK_SykLfIpv6lv1eQrEiK6S0aa1mMLxFyrINj7DBr6APkzXScGokVQF5W-Y3uBETQzNm9x_7x_xs))

All the files for the installation are found in [Github in p2ops-i01/assignment02/SAP NetWeaver ABAP/ SAP NetWeaver files](https://github.com/HoGentTIN/p2ops-i01/tree/master/assignment02/SAP%20NetWeaver%20ABAP/SAP%20NetWeaver%20files)

## Prerequisites
Packer, VirtualBox and Vagrant is available on Windows via [Chocolatey]([https://chocolatey.org](https://l.facebook.com/l.php?u=https%3A%2F%2Fchocolatey.org%2F&h=ATNtSwKt-pZmWmxyvIZ-SUQY5Ko9xHeK8OVqboHkKBoKBgRAAYXEzg-VK_SykLfIpv6lv1eQrEiK6S0aa1mMLxFyrINj7DBr6APkzXScGokVQF5W-Y3uBETQzNm9x_7x_xs)).

	$ choco install packer
	$ choco install virtualbox
	$ choco install vagrant
Download and extract the [sap_netweaver_as_abap_750_sp02_ase_dev_edition.partX.rar]([https://tools.hana.ondemand.com/#abap](https://l.facebook.com/l.php?u=https%3A%2F%2Ftools.hana.ondemand.com%2F%23abap&h=ATNtSwKt-pZmWmxyvIZ-SUQY5Ko9xHeK8OVqboHkKBoKBgRAAYXEzg-VK_SykLfIpv6lv1eQrEiK6S0aa1mMLxFyrINj7DBr6APkzXScGokVQF5W-Y3uBETQzNm9x_7x_xs)) files to the folder: **./sapinst**

## Usage

### Packer
Inside the SAP NetWeaver directory use following commands concerning packer:

	cd packer
	cd openSUSE-42.1
	$ packer build -only=virtualbox-iso template.json

Wait for the download and build to complete.

### Vagrant

If the gnome desktop is not desired, comment the following line in the vagrant file:

	#	config.vm.provision "shell", path: "install/gnome.sh"

Wait until vagrant is finished, restart the instance using:
	
	vagrant reload

### Login
Login: vagrant/vagrant

### Install SAP NW AS ABAP 750 SP02 Dev. Edition
The files and folder, on the same level as the vagrant file, will be available under /vagrant

	sudo -i
	<password>
	cd /vagrant
	./install.sh

Read & Accept the license agreement. When prompted for the OS users password enter your master password of the virtual Linux OS instance.

###  Start the SAP system:
Switch to user npladm in the console and start the SAP system:
	
		su npladm
		startsap ALL
Any post - and additional information, License key and first steps can be found here : [SAP NW AS ABAP 7.50 SP2 – Developer Edition to Download: Concise Installation Guide](https://blogs.sap.com/2016/11/03/sap-nw-as-abap-7.50-sp2-developer-edition-to-download-consise-installation-guide/)

### VBox

Starting or stopping the virtualbox can be done using:

	vagrant up
	vagrant halt

Or with the VirtualBox UI:
![Oracle_VM_Manager](https://i.imgur.com/o6GxYR7.png)

