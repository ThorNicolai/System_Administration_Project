<!DOCTYPE html>
<html>

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>decumentation Vagrant WISA</title>
  <link rel="stylesheet" href="https://stackedit.io/style.css" />
</head>

<body class="stackedit">
  <div class="stackedit__html"><h2 id="setup-vagrant-for-windows-wisa">SetUp Vagrant for Windows WISA</h2>
<ul>
<li>
<p>Go to the website  <a href="https://www.vagrantup.com/downloads.html">https://www.vagrantup.com/downloads.html</a>  and download the appropriate version.</p>
</li>
<li>
<p>Install vagrant.</p>
</li>
<li>
<p>In CMD, go to the folder where you want to use Vagrant.</p>
</li>
<li>
<p>Go to the Windows server 2016 Vagrant Box you need to download: 	   
  hhttps://app.vagrantup.com/mwrock/boxes/Windows2016
  </p>
</li>
<li>
<p>In the CMD run the following command and wait for the box installation<br>
</p>
</li>
<pre><code>  		vagrant init mwrock/Windows2016</code></pre>
<li>
<p>In the CMD run the command </p>
</li>
<pre><code>  		vagrant up
</code></pre>
<li>
<p>Your VM should now be created and accessible from VirtualBox</p>
</li>
</ul>
</div>
</body>

</html>
