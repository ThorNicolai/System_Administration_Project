
# Documentation Lab 4

> All passwords and secrets used in this exercise are: io1

1. To cable routers to eachother through serial ports with the Data Communications Equipment protocol (DCE) you will first off have to add a module to the Router in PacketTracer (PT) that has one or more serial ports.
The correct module for the router in this case was for example the WIC-2T Module, which includes a  dual-serial port.
Once setup clear all the config of the routers using:

		Router#erase startup-config
		Router#reload

2. Basic router configuration to follow the Topology Diagram using:

		Router(config)#hostname
		Router(config)#no ip domain-lookup
		Router(config)#enable secret cisco

* For console and vty line use a password (io1):
	
		Router(config-line)#password class
		Router(config-line)#login

3. **(Optional)** Using the '*Router (config-line)# logging synchronous*' command prevents IOS messages delivered to the console or lines from interrupting your keyboard input.

4. To set the interval that the EXEC command interpreter waits until user input is detected, we can use the '*exec-­timeout*' line configuration command.  In a lab environment, you can specify "no timeout" by entering the '*exec-­timeout 0 0*' command for specific lines.

5. **(Optional)** The '*debug ip routing*' command in privileged EXEC mode shows when routes are added, modified, and deleted from the routing table. Turn of debugging using '*no debug ip routing*'

6.  Configure the IP addresses as specified in the Topology Diagram

		R1(config)#interface fastethernet0/0
		R1(config-­if)#ip address 172.16.3.1 255.255.255.0
		R1(config-­if)#no shutdown
		R1(config)#interface Serial 0/1/0
		R1(config-­if)#ip address 172.16.2.1 255.255.255.0
		R1(config-­if)#no shutdown

7. Because R1 is the DCE side of our lab environment, we must specify how fast the bits will be clocked between R1 and R2. You can specify any valid clocking speed. Use the *?* to find the valid rates.  
(R2 also needs a clock rate on the serial port to R3)
Here we used 64000 bps

		R1(config)#interface Serial 0/1/0
		R1(config-­if)#clock rate 64000

8. Enter the '*show ip route*' command to verify that the new route is now in the routing table for your specific routers

9. Save the running config to the startup config using:

		R1#copy running-config startup-config
		Press ENTER for Destination filename [startup-config]

11. Configure all routers accordingly and save the running configurations to the startup configurations 

12. Configure IP Addressing on the Host PCs, including default gateways.

#### At this point routers only 'know' about directly connected networks
 * Troubleshooting: Check status of interfaces using 'show ip interface brief'
	 


----------


## Configure a Static Route Using a Next-Hop Address

* Syntax

		Router(config)# ip route {network-­address} {subnet-­mask} {ip-­address}
	* **network-­address**: Destination network address of the remote network to be added to the routing table.

	* **subnet-­mask:** Subnet mask of the remote network to be added to the routing table. The subnet mask can be modified to summarize a group of networks.

	* **ip-­address:** Commonly referred to as the next-hop router's IP address.
* For Router 3 route accordingly and  verify through '*show ip route*':
			
		R3(config)#ip route 172.16.1.0 255.255.255.0 192.168.1.2
* For Router 2 route accordingly and  verify through '*show ip route*':

		R2(config)#ip route 192.168.2.0 255.255.255.0 192.168.1.1
Pinging from host PC3 to host PC2 should be possible now.


----------


## Configure a Static Route Using an Exit Interface.

* Syntax

		Router(config)# ip route {network-­address} {subnet-­mask} {exit-interface}

	* **exit-interface:** Outgoing interface that would be used in forwarding packets to the
destination network.

* For Router 3 route accordingly and verify through ‘_show ip route_’:

		R3(config)#ip route 172.16.2.0 255.255.255.0 Serial0/1/1
* For Router 2 route accordingly and verify through ‘_show ip route_’:

		R2(config)#ip route 172.16.3.0 255.255.255.0 Serial0/1/0

>Although R2 can route to all networks in the Topology, this does not guarantee that other routers can
route back to R2.
----------

## Configure a Default Static Route.

>Instead of filling the routing table of R1 with static routes, we could assume that R1 is a stub router. This
means that R2 is the default gateway for R1. If R1 has packets to route that do not belong to any of R1
directly connected networks, R1 should send the packet to R2. However, we must explicitly configure R1
with a default route before it will send packets with unknown destinations to R2. Otherwise, R1 discards
packets with unknown destinations

* Syntax
		
		Router(config)#ip route 0.0.0.0 0.0.0.0 { ip-­address | interface }

* For Router 1 route accordingly and verify through ‘*show ip route*’:
		
		R1(config)#ip route 0.0.0.0 0.0.0.0 172.16.2.2

## Configure a Summary Static Route.

>In this exercise we we already have two static routes on R3 for 172.16.2.0/24 and 172.16.1.0/24. Because these networks are so close together, we can summarize them into one route. Again, doing this helps reduce the size of routing tables, which makes the route lookup process more efficient.*
The network to be used in the summary route is 172.16.0.0/22.

	R3(config)#ip route 172.16.0.0 255.255.252.0 192.168.1.2
	
	R3(config)#no ip route 172.16.1.0 255.255.255.0 192.168.1.2
	R3(config)#no ip route 172.16.2.0 255.255.255.0 Serial0/0/0

View the routing table to verify the new static route entry using *Router#show ip route*.

