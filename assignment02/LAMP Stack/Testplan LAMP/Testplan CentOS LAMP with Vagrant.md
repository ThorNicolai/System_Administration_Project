## Prerequisites
- Vagrant, VirtualBox are set up on the Windows host system.
- There is a running instance of a LAMP Stack CentOS VM.
- See [the documentation](https://github.com/HoGentTIN/p2ops-i01/edit/master/assignment02/LAMP%20Stack/Documentation/Setup.md) for setting up a VM.

## Testing
- Login to the virtual machine with the username "vagrant" and the password "vagrant".
- In the VM, enter the command "ip addr".
- Copy the 172.28.128.X address.
- Enter the ping command from your host to the copied IP.
	- ping 172.28.128.X
	- Verify that the ping completes succesfully.
- Enter the copied IP in your preferred browser on your host.
	- http://172.28.128.X
	- Verify that you get the default "Apache working" page.
- Browse to http://172.28.128.X/sqltest.php on your host.
	- Verify you get the "There are no tables in $dbname, but SQL works!" message.

<!--stackedit_data:
eyJoaXN0b3J5IjpbLTEwODk3Nzk3NjhdfQ==
-->
