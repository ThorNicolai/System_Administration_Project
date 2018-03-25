Set up the environment

1. Install vagrant: https://www.vagrantup.com/
2. Install Virtualbox: https://www.virtualbox.org/
3. Search for an appropriate "box". This is a VM.
https://app.vagrantup.com/boxes/search?utf8=%E2%9C%93&sort=downloads&provider=&q=windows+server+2016

For this testplan the following box has to be used: DBSowner/ProjectsSysAdm

    #OR create your own "box": more detailed instructions can be foud here https://www.vagrantup.com/docs/virtualbox/boxes.html
         !!! THE 4 FOLLOWING STEPS DON'T NEED TO BE DONE DURING A DEMO, SINCE IT TAKES A WHILE AND HAS ALREADY BEEN DONE.
        #a. Set up a virtual machine of the desired Operating System (for example: Windows server 2016), using virtual box
        #b. Use the following command : vagrant package --base %NAME_VM% --output %PLACE/TO/PUT/.BOX% #CORRECT
        #c. Go to: https://app.vagrantup.com/, create an account and a new box. 
            You can upload only '.box' files so make sure the previous step was succesful
        #d. Don't forget to 'release' the box on the website so that others can (including you) can download it from the Hashicorp Servers.


In CMD, go to the folder where you want to use Vagrant. (This can be done by going to the desired map and typing 'powershell' in the navigation-bar on GUI enabled Windows Servers)

4. Run the command "vagrant init DBSowner/ProjectsSysAdm --box-version 1.0" (A Vagrantfile should now be created)
#Custom settings can be made within this file. 

!!!To make the testing easier, a reference Vagrantfile is included in this git-project (in the 'swap me'-map) and should be swapped with the one created (as should the other files for testing purposes later in this document!).

5. After placing the files from the 'swap me'-map into the map where the original Vagrantfile was located:
Run the command "vagrant up"


The Windows credentials are the following: Administrator - PolPol22

Your VM should now be created and accessible from VirtualBox
(In case there is a problem with starting the vm, use the 'vagrant up --provision' command to make sure the script to install the WISA tries to run again)

----

Test the Wisa stack

  1. Open the project using the PRJOECT_NAME.sln file (Located in the DOTNETproject-map)
  2. Right click on the application in the solution explorer and select the "Publish..." option
  3. Create new publishing profile: "IIS, FTP, etc"
  4. Enter following settings:
        Publish method: Web Deploy
        Server: 192.168.56.103
        Site name: Default Web Site
        User name: Administrator
        Password: PolPol22
        Destination URL: (keep this field clear)
  5.Validate connection and press "next"
  6.Under Databases you enter the following remote connection string: Data Source=WIN-5RA2OGDHQ4S\SQLEXPRESS;Integrated Security=True;Initial Catalog=Bierhalle;
  7. Press Save and Publish the Application.
  8. To test, you can surf on your host-machine to 192.168.56.103 and the application should be running
  9. To verify the Database functionality: try to add, edit and delete information and reload the page after each operation.