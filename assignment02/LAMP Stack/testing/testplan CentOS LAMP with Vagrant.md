## Testing

- In the VM, enter the command "ip addr".
- Copy the 172.28.128.X address.
- Enter the ping command from your host to the copied IP.
	- Verify that the ping completes succesfully.
- Enter the copied IP in your preferred browser on your host.
	- Verify that you get the default "Apache working" page.
- Browse to http://IP/sqltest.php on your host.
	- Verify you get the "There are no tables in $dbname, but SQL works!" message.

<!--stackedit_data:
eyJoaXN0b3J5IjpbLTEwODk3Nzk3NjhdfQ==
-->
