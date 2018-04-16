---


---

<h2 id="test">Test</h2>
<p>Test the Wisa stack</p>
<ol>
<li>Open the project using the PROJECT_NAME.sln file (Located in the DOTNETproject-map)</li>
<li>Right click on the application in the solution explorer and select the “Publish…” option</li>
<li>Create new publishing profile: “IIS, FTP, etc”</li>
<li>Enter following settings:
<ul>
<li>Publish method: Web Deploy</li>
<li>Server: 192.168.56.103</li>
<li>Site name: Default Web Site</li>
<li>User name: Administrator</li>
<li>Password: PolPol22</li>
<li>Destination URL: (keep this field clear) 5.Validate connection and press “next”</li>
</ul>
</li>
</ol>
<p>6.Under Databases you enter the following remote connection string: "Data Source=WIN-5RA2OGDHQ4S\SQLEXPRESS;Integrated Security=True;Initial Catalog=Bierhalle;"<img src="https://i.imgur.com/rEapDcU.png" alt="enter image description here"><br>
5.  Press Save and Publish the Application.<br>
6.  To test, you can surf on your host-machine to 192.168.56.103 and the application should be running<br>
<img src="https://i.imgur.com/MUkCOry.png" alt="enter image description here"><br>
7.  To verify the Database functionality: try to add, edit and delete information and reload the page after each operation.<br>
8. <img src="https://i.imgur.com/9zC6zwg.png" alt="enter image description here"></p>

