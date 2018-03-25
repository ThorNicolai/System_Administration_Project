  1. Open the project using the PRJOECT_NAME.sln file
  2. Right click on the application in the solution explorer and select the "Publish..." option
  3. Create new publishing profile: "IIS, FTP, etc"
  4. Enter following settings:
        Publish method: Web Deploy
        Server: for example: 192.168.56.103
        Site name: Default Web Site
        User name: THE_WINDOWSCREDENTIALS_OF_THE_CLIENT
        Password: THE_WINDOWSCREDENTIALS_OF_THE_CLIENT
        Destination URL: 
  5.Validate connection and press "next"
  6.Under Databases you enter the following remote connection string: Data Source=WIN-5RA2OGDHQ4S\SQLEXPRESS;Integrated Security=True;Initial Catalog=Bierhalle; 
  !!If the user changed the name of the PC, it's possible that this connection string might differ
  7. Press Save and Publish the Application.
  8. To test, you can surf on your host-machine to 192.168.56.103 and the application should be running