## Prerequisites

- Vagrant, VirtualBox are set up on the Windows host system.
- Create a directory on your host OS to execute this test in.
- This could be C:/test for example.
- The files you need are in https://github.com/HoGentTIN/p2ops-i01/tree/master/assignment02/LAMP%20Stack.
- The files you need are "lamp.sh", "user_input.sh", "sqltest.php" and "vagrantfile".
- The easiest way to get these is to download the whole repo, or copy them from your local repo. 
- Copy these files to the directory you created for the test.

## Testing
- Navigate to the directory you created for testing on your host.
- From the command line in the testing directory, run "vagrant up".
	- This might take a while, so just wait until it finishes.
- When it's finished, open the newly created VM in VirtualBox.
- Login with the user "vagrant" and the password "vagrant".
-  navigate to /vagrant/ in the VM. run the user_input.sh file.
- Follow the instructions of the script.
