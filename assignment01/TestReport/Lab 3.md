## Testreport on Lab 3

1. Display a summary list of the interfaces on the router and switch. (check if only the interfaces that are necesary are in an UP-state).

	*	Both on the Switch and the Router the correct interfaces were up and had the correct ip addresses assigned.

2.  Display the routing table on the router check if there are only necesary routes.
	*	show ip route confirms the expected response ✓

3. Pinging PC-B from PC-A works accordingly. 
	
		C:\>ping 192.168.0.3
		Pinging 192.168.0.3 with 32 bytes of data:
		Reply from 192.168.0.3: bytes=32 time<1ms TTL=127
		Reply from 192.168.0.3: bytes=32 time=1ms TTL=127
		Reply from 192.168.0.3: bytes=32 time=1ms TTL=127
		Reply from 192.168.0.3: bytes=32 time<1ms TTL=127

4. Verify the security of the router via  PC-A.
		
		banner motd ^C Unauthorized ^C

### Test Executor: Thor Nicolaï - 26/02/2018
