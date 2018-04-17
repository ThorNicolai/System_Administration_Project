Note: Before starting this test, the prerequisites should be fulfilled.
These can be found under the document ‘prerequisites’

Test the Wisa stack

1.  Open the project using the PROJECT\_NAME.sln file (Located in the
    DOTNETproject-map)
2.  Right click on the application in the solution explorer and select
    the “Publish…”
    option![](https://i.gyazo.com/01309cc99df0fd1ed215601a9db73d6f.png)
3.  Create new publishing profile: “IIS, FTP,
    etc”![](https://i.gyazo.com/130940a749ea0901381bacb6850e2fc4.png)
4.  Enter following settings:
    -   Publish method: Web Deploy
    -   Server: 192.168.56.103
    -   Site name: Default Web Site
    -   User name: Administrator
    -   Password: PolPol22
    -   Destination URL: (keep this field clear)

5.  Validate connection and press
    “next”![](https://i.gyazo.com/6fe87857165525e3551cdcd30ac6a61c.png)
6.  Under Databases you enter the following remote connection string:
    Data Source=WIN-5RA2OGDHQ4S\\SQLEXPRESS;Integrated
    Security=True;Initial
    Catalog=Bierhalle;![](https://i.gyazo.com/6fe87857165525e3551cdcd30ac6a61c.png)
7.  Press Save and Publish the Application.
8.  To test, you can surf on your host-machine to 192.168.56.103 and the
    application should be running
9.  To verify the Database functionality: try to add, edit and delete
    information and reload the page after each operation.

