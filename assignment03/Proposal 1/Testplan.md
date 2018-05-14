## Prerequisites 
- Packet tracer is installed on the host machine
- The packet tracer file for Proposal 1 is opened

## Testing

- Fast forward time inside Packet Tracer to ensure all connections are established 
- Check if the Router/Switches are secured with necessary passwords, the corresponding password can be found in [passwords.md on Github](https://github.com/HoGentTIN/p2ops-i01/blob/master/assignment03/Proposal%201/passwords.md)

### Router
- Navigate to the CLI and verify the run using
	
		<password>
		>enable
		<password>
		#show run

	- Verify the DHCP pools: PC/PHONE/GUEST
	- Verify the corresponding VLAN's: interface 1.10/1.20/1.30
	- Verify the telephony-services for source-address and number distribution for every ephone
- Check if the lines all set to ssh

### Switch

- Verify that the interfaces and VLAN's are configured correctly and the lines are all set to ssh

### IP-phone
- Using the Inspect (i) function in Packet tracer you can verify the IP address assigned to the ipphone with DHCP, this ip should follow 192.168.20.x 
- Navigate to both ipphone1 and ipphone2 their GUI
	- Pick up the phone on ipphone2 and dial 101 (number set for ipphone1)
	- Verify if the call connects to ipphone1 and pick up.
### PC
- Verify the ip of the GUEST-Laptop by navigating to the *global settings* in the config tab, this ip should follow 192.168.30.x
- Verify the ip of an Employee-Laptop, this ip should follow 192.168.10.x

													
