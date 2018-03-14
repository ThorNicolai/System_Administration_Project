## Prerequisites
TODO: show sql shows in apache with a webpage with the DB and add login with user vagrant

- Vagrant, VirtualBox are set up on the Windows host system.
- The lamp.sh and user_input.sh scripts and the vagrant file are present on the system in a folder designed for the test. The files are in https://github.com/HoGentTIN/p2ops-i01/tree/master/assignment02/Linux%20LAMP%20webserver

## Testing

- From the command line in the testing directory, run "vagrant up".
- Open the newly created VM from VirtualBox.
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
- Edit the file and change the following variables to the ones you set with the user_input.sh script
	- dbname
	- dbuser
	- dbpass
- Browse to http://IP/sqltest.php on your host and verify you get the "There are no tables in $dbname, but SQL works!" message.

<!--stackedit_data:
eyJoaXN0b3J5IjpbLTEwODk3Nzk3NjhdfQ==
-->
