--- ---

Test
----

Test the Wisa stack

1.  Open the project using the PROJECT\_NAME.sln file (Located in the
    DOTNETproject-map)
2.  Right click on the application in the solution explorer and select
    the “Publish…” option
3.  Create new publishing profile: “IIS, FTP, etc”
4.  Enter following settings:
    -   Publish method: Web Deploy
    -   Server: 192.168.56.103
    -   Site name: Default Web Site
    -   User name: Administrator
    -   Password: PolPol22
    -   Destination URL: (keep this field clear) 5.Validate connection
        and press “next”

6.Under Databases you enter the following remote connection string:
"Data Source=WIN-5RA2OGDHQ4S\\SQLEXPRESS;Integrated
Security=True;Initial Catalog=Bierhalle;"![enter image description
here](https://i.imgur.com/rEapDcU.png)\
 5. Press Save and Publish the Application.\
 6. To test, you can surf on your host-machine to 192.168.56.103 and the
application should be running\
 ![enter image description here](https://i.imgur.com/MUkCOry.png)\
 7. To verify the Database functionality: try to add, edit and delete
information and reload the page after each operation.\
 8. ![enter image description here](https://i.imgur.com/9zC6zwg.png)
