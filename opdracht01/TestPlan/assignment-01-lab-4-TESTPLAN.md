---


---

<h2 id="testplan-lab-4---basic-static-route-configuration">Testplan Lab 4 - Basic Static Route Configuration</h2>
<p>Verifying connectivity</p>
<ul>
<li>Open the command prompt on PC1 and enter these commands:
<ul>
<li>ping 172.16.1.10</li>
<li>ping 192.168.2.10</li>
<li>Verify both PC’s reply.</li>
</ul>
</li>
<li>Open the command prompt on PC3 and enter this command:
<ul>
<li>ping 172.16.1.10</li>
<li>Verify this PC replies.</li>
</ul>
</li>
<li>Power cycle all devices to make sure all configuration is correctly stored
<ul>
<li>Repeat the previous steps. The outcome should always be the same.</li>
</ul>
</li>
</ul>

Security testing

Check if the routers ask for a password when entering user and privileged EXEC mode. Follow these steps for each router.
- Open the CLI and verify if the router asks for a password.
- Enter the “enable” password and verify if the router asks for the password.
