## Testreport LAMP

After completing the [documentation](https://github.com/HoGentTIN/p2ops-i01/blob/master/assignment02/LAMP%20Stack/Documentation/Automated%20LAMP%20installation%20on%20CentOS%20with%20Vagrant.md) on setting up an instance of LAMP on CentOs with Vagrant, the VM was ready to be tested.

After logging in, running the *ip addr* and *ping* command I could see that connection could be made succesfully.



![Ping](https://i.imgur.com/PLQUD7K.png)

For the next step I navigated to http://172.28.128.3 in my prefered browser  and here I could verify that the default Apache page was loaded.

![Apache](https://i.imgur.com/caFlpFU.png)

Last we had to check for a succesfull SQL connection with the database and this could be verified by browsing to http://172.28.128.3/sqltest.php , this also worked perfectly.

![SQL](https://i.imgur.com/zhryChv.png)
