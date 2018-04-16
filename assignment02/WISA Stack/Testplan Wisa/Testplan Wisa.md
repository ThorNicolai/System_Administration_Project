<!DOCTYPE html>
<html>

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="https://stackedit.io/style.css" />
</head>

<body class="stackedit">
  <div class="stackedit__html"><p>Note: Before starting this test, the prerequisites should be fulfilled. These can be found under the document ‘prerequisites’</p>
<p>Test the Wisa stack</p>
<ol>
<li>Open the project using the PROJECT_NAME.sln file (Located in the DOTNETproject-map)</li>
<li>Right click on the application in the solution explorer and select the “Publish…” option<img src="https://i.gyazo.com/01309cc99df0fd1ed215601a9db73d6f.png" alt=""></li>
<li>Create new publishing profile: “IIS, FTP, etc”<img src="https://i.gyazo.com/130940a749ea0901381bacb6850e2fc4.png" alt=""></li>
<li>Enter following settings:
<ul>
<li>Publish method: Web Deploy</li>
<li>Server: 192.168.56.103</li>
<li>Site name: Default Web Site</li>
<li>User name: Administrator</li>
<li>Password: PolPol22</li>
<li>Destination URL: (keep this field clear)</li>
</ul>
</li>
<li>Validate connection and press “next”<img src="https://i.gyazo.com/6fe87857165525e3551cdcd30ac6a61c.png" alt=""></li>
<li>Under Databases you enter the following remote connection string: Data Source=WIN-5RA2OGDHQ4S\SQLEXPRESS;Integrated Security=True;Initial Catalog=Bierhalle;<img src="https://i.gyazo.com/6fe87857165525e3551cdcd30ac6a61c.png" alt=""></li>
<li>Press Save and Publish the Application.</li>
<li>To test, you can surf on your host-machine to 192.168.56.103 and the application should be running</li>
<li>To verify the Database functionality: try to add, edit and delete information and reload the page after each operation.</li>
</ol>
</div>
</body>

</html>
