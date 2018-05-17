# Testreport SAP NW AS ABAP 750 SP02


## Automated Setup VM and SAP ABAP installation

Following the testplan, the first thing that needs to be done is following is complete the Automated Setup VM and SAP ABAP installation.
-> Placed all necessary filles correctly in the installation directory.
-> Entered the command: 

    $ packer build -only=virtualbox-iso template.json

![](https://i.gyazo.com/6349601576cf3ae6f58a4c9c4881740f.png)

-> Log in as: vagrant/vagrant

![enter image description here](https://i.gyazo.com/adf91d92c00d18acf717d0fa761148d3.png)


## Install SAP NW AS ABAP 750 SP02 Dev. Edition

-> Entered the following commands:

    su npladm
    **vagrant**
    sapstart ALL

![](https://i.imgur.com/SQf3cwv.png)

Instance on host chcalnplci started => SAP Developer environment is running
