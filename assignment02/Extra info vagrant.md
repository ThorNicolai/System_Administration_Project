Using Vagrant

- Go to the website https://www.vagrantup.com/downloads.html and download the appropriate version. 
- Install vagrant.
- In CMD, go to the folder where you want to use Vagrant.
- Search for an appropriate "box". This is a VM.
	- https://app.vagrantup.com/boxes/search?utf8=%E2%9C%93&sort=downloads&provider=&q=windows+server+2016
- Run the command "vagrant init $box-name"
- Run the command "vagrant up"
- Your VM should now be created and accessible from VirtualBox
- From there on out you will have to put the script you made in the vagrantfile in the directory.
- This is how my Linux script is run: config.vm.provision "shell", path: "lamp.sh", the Windows script should be similar
