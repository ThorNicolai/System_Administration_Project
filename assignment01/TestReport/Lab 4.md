## Testreport on Lab 4

1. Verifying connectivity on PC1

	*	On PC1 pinging to the other 2 pc's was succesfull.
        <li>ping 172.16.1.10</li>
        <li>ping 192.168.2.10</li>

2. Verifying connectivity on PC3

	*	On PC3 pinging to the other 2 pc's was succesfull.
        <li>ping 172.16.1.10</li>

3. Power cycle all devices to make sure all configuration is correctly stored 
    
    *After shutting down all the devices, the settings that were changed were still in effect.
	
		C:\>ping 192.168.0.3
		Pinging 192.168.0.3 with 32 bytes of data:
		Reply from 192.168.0.3: bytes=32 time<1ms TTL=127
		Reply from 192.168.0.3: bytes=32 time=1ms TTL=127
		Reply from 192.168.0.3: bytes=32 time=1ms TTL=127
		Reply from 192.168.0.3: bytes=32 time<1ms TTL=127

4. Security testing
		
	*	Upon opening the terminal, a password is asked to acces the router.
    *   Upon entering the 'enable' command, a password is asked.

### Test Executor: Mario Verstraeten - 26/02/2018
