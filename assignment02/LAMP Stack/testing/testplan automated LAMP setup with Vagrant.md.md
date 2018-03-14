---


---

<h2 id="prerequisites">Prerequisites</h2>
<p>TODO: show sql shows in apache with a webpage with the DB and add login with user vagrant</p>
<ul>
<li>Vagrant, VirtualBox are set up on the Windows host system.</li>
<li>The <a href="http://lamp.sh">lamp.sh</a> and user_input.sh scripts and the vagrant file are present on the system in a folder designed for the test. The files are in <a href="https://github.com/HoGentTIN/p2ops-i01/tree/master/assignment02/Linux%20LAMP%20webserver">https://github.com/HoGentTIN/p2ops-i01/tree/master/assignment02/Linux LAMP webserver</a></li>
</ul>
<h2 id="testing">Testing</h2>
<ul>
<li>From the command line in the testing directory, run “vagrant up”.</li>
<li>Open the newly created VM from VirtualBox.</li>
<li>Login with the user “vagrant” and the password “vagrant”.</li>
<li>navigate to /vagrant/ in the VM. run the user_input.sh file.
<ul>
<li>Hint: If you get “$’\r’: command not found” errors, this means the script is in Windows format and needs to be set to the Linux format.</li>
<li>You can achieve this by installing dos2unix
<ul>
<li>sudo yum install dos2unix</li>
</ul>
</li>
<li>Then run
<ul>
<li>sudo dos2unix user_input.sh</li>
</ul>
</li>
</ul>
</li>
<li>In the VM, enter the command “ip addr”.</li>
<li>Copy the 172.28.128.X address and ping to it from the command prompt on your host.
<ul>
<li>Verify that the ping completes succesfully.</li>
</ul>
</li>
<li>Enter the copied IP in your preferred browser on your host.
<ul>
<li>Verify that you get the default “Apache working” page.</li>
</ul>
</li>
<li>On the VM, copy the “sqltest.php” file to /var/www/html.</li>
<li>Edit the file and change the following variables to the ones you set with the user_input.sh script
<ul>
<li>dbname</li>
<li>dbuser</li>
<li>dbpass</li>
</ul>
</li>
<li>Browse to <a href="http://IP/sqltest.php">http://IP/sqltest.php</a> on your host and verify you get the “There are no tables in $dbname, but SQL works!” message.</li>
</ul>

