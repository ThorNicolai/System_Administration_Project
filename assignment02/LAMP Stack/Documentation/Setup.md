## Prerequisites

- Vagrant, VirtualBox are set up on the Windows host system.
- The files you need are in https://github.com/HoGentTIN/p2ops-i01/tree/master/assignment02/LAMP%20Stack.
- The files you need are "lamp.sh", user_input.sh and "vagrantfile".
- If you plan on using this box for testing, also include "sqltest.php".
- The easiest way to get these is to download the whole repo, or copy them from your local repo. 
- Copy these files to the directory you created for the VM.

## Setup
- Navigate to the directory you created for the VM on your host.
- From the command line in this directory, run "vagrant up".
	- This might take a while, so just wait until it finishes.
- When it's finished, open the newly created VM in VirtualBox.
- Login with the user "vagrant" and the password "vagrant".
- navigate to /vagrant/ in the VM. run the user_input.sh file.
- Follow the instructions of the script.
