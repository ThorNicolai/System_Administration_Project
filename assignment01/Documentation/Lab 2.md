<h2>Configure and Verify Basic Switch Settings</h2>

##Enter privileged EXEC mode.
    Switch> enable
    Switch#
    
##Enter configuration mode.
    Switch# configure terminal
    Switch(config)#
    
##Give the switch a name.
    Switch(config)# hostname S1
    S1(config)#

##Prevent unwanted DNS lookups.
    S1(config)# no ip domain-lookup
    S1(config)#

##Enter local passwords.
    S1(config)# enable secret class
    S1(config)# line con 0
    S1(config-line)# password cisco
    S1(config-line)# login
    S1(config-line)# exit
    S1(config)#

##Enter a login MOTD banner.
    S1(config)# banner motd %Unauthorized access is strictly prohibited and prosecuted to the full extent of the law.%

##Save the configuration.
    S1# copy running-config startup-config
    Destination filename [startup-config]? [Enter]
    Building configuration...
    [OK]
    S1#

##Display the current configuration.
    S1# show running-config

##Display the IOS version and other useful switch information.
    S1# show version

##Display the status of the connected interfaces on the switch.
    S1# show ip interface brief


<h2>Initializing and Reloading a Switch</h2>

##Determine if there have been any virtual local-area networks (VLANs) created.
    Switch# show flash

##Delete the VLAN file.
    Switch# delete vlan.dat
    
##Erase the startup configuration file.
    Switch# erase startup-config

##Reload the switch.
    Switch# reload



