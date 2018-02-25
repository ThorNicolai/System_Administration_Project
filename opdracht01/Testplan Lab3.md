Things to be tested:

1/Display a summary list of the interfaces on the router and switch. (check if only the interfaces that are necesary are in an UP-state)
	-On S1: result: F0/5 and F0/6 UP
	commando's:
	VIA SWITCH CLI
	enable
	#show ip interface brief



	-On R1: result: G0/0 192.168.0.1 255.255.255.0 UP
			G0/1 192.168.1.1 255.255.255.0 UP
	commando's:
	VIA ROUTER CLI
	(password = cisco)
	enable (password = class)
	#show ip interface brief

2/Display the routing table on the router. (check if there are only necesary routes)
	commando's:
	VIA ROUTER CLI
	(password = cisco)
	enable (password = class)
	#show ip route
	192.168.0.0/24 is variably subnetted, 2 subnets, 2 masks
	C       192.168.0.0/24 is directly connected, GigabitEthernet0/0
	L       192.168.0.1/32 is directly connected, GigabitEthernet0/0
     	192.168.1.0/24 is variably subnetted, 2 subnets, 2 masks
	C       192.168.1.0/24 is directly connected, GigabitEthernet0/1
	L       192.168.1.1/32 is directly connected, GigabitEthernet0/1

3/Verify network connectivity (-ping from PC-A to PC-B)
	commando's:
	VIA PC-A COMMAND PROMPT
	ping 192.168.0.3
		
4/Verify the security of the router (check vty)
	VIA PCA COMMAND PROMPT
	telnet 192.168.0.1
	(password = cisco)
	enable (password = class)
	show run | begin banner
	
	-check banner is set (command: show banner motd)
	-check privileged EXEC password is 'class'
	-check line password is 'cisco'