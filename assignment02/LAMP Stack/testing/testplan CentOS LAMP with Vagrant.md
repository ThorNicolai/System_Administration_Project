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
	- Hint: If you get "$'\r': command not found" errors, this means the script is in Windows format and needs to be set to the Linux format.
	- You can achieve this by installing dos2unix
		- sudo yum install dos2unix
	- Then run 
		- sudo dos2unix user_input.sh
- In the VM, enter the command "ip addr".
- Copy the 172.28.128.X address and ping to it from the command prompt on your host.
	- Verify that the ping completes succesfully.
- Enter the copied IP in your preferred browser on your host.
	- Verify that you get the default "Apache working" page.
- On the VM, copy the "sqltest.php" file to /var/www/html.
	- (assuming you are still in the /vagrant/ directory) sudo cp sqltest.php /var/www/html
- Edit the file and change the following variables to the ones you set with the user_input.sh script
	- dbname
	- dbuser
	- dbpass
- Enter the command "sudo service httpd restart"
- Browse to http://IP/sqltest.php on your host and verify you get the "There are no tables in $dbname, but SQL works!" message.

<!--stackedit_data:
eyJoaXN0b3J5IjpbLTEwODk3Nzk3NjhdfQ==
-->
