## Testplan Assignment 2: SAP NetWeaver

## Prerequisites

Complete the Automated or the Manual installation of the VM and Netweaver installation.

## Test
Start by running the VM and run the SAP Sytem using: 
	
	su npladm
	<password>
	sapstart ALL

Now use a FrontEnd app like SAP Logon to connect to the developer environment.

Use the following parameters:
	
 - Application Server: 127.0.0.1
 - Instance Number: 00 (these are zeros)
 - System ID: NPL

Once connected you can use a logon such as:
	
User: sap*
Password: Appl1ance

Once the connection is established, you verified a correct installation of SAP Netweaver.
