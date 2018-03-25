Go to the website https://www.vagrantup.com/downloads.html and download the appropriate version.

Install vagrant.

Search for an appropriate "box". This is a VM.
https://app.vagrantup.com/boxes/search?utf8=%E2%9C%93&sort=downloads&provider=&q=windows+server+2016


OR create your own "box": more detailed instructions can be foud here https://www.vagrantup.com/docs/virtualbox/boxes.html

1. Set up a virtual machine of the desired Operating System (for example: Windows server 2016), using virtual box
2. Use the following command : vagrant package --base %NAME_VM% --output %PLACE/TO/PUT/.BOX% 
3. Go to: https://app.vagrantup.com/, create an account and a new box. 
   You can upload only '.box' files so make sure the previous step was succesful
4. Don't forget to 'release' the box on the website so that others can (including you) can download it from the Hashicorp Servers.

In CMD, go to the folder where you want to use Vagrant.

Run the command "vagrant init $box-name" (for example: ubuntu/trusty64)

Run the command "vagrant up"

Your VM should now be created and accessible from VirtualBox