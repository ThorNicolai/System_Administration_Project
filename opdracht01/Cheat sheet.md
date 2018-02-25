
# Cheat sheet Cisco commands

## Modes

| Mode     | Prompt                |
| :---     | :---                     |
| User EXEC |  Device>|
| Privileged EXEC | Device# |
| Global Config | Device(config)#|
| Interface Config | Device(config-if)# |
| Line Config | Device(config-line)# |

## Keyboard Shortcuts


| Input| Action|
| :---     | :---                     |
| Up Arrow ↑ | Automatically re-types last command |
| Ctrl+Shift+6 | Cancels whatever it's currently doing |
| Ctrl+C | Exits config mode|
| Ctrl+Z | Applies current command & returns to priv. EXEC mode |
| Ctrl+U | Erases anything on current prompt line |
| Tab| Completes abbreviated command |

## General Commands

|Command | Function |
|:--- | :---|
| enable  |  user EXEC  → priv. EXEC |
| config terminal | priv. EXEC → global config|
|interface | global config → interface config|
| line | global config → line config| 
|show running-config | shows current config |
| copy running-config startup-config| saves current config |
| no ip domain-lookup| keeps router from trying to read bad cdms as hostnames |
| write erase | **use after labs to reset  configs** |
| erase | **second  command to use to reset  configs** |
| erase startupconfig | **use after labs to reset  configs** |
|delete vlan.dat | **use after labs to reset VLAN configs**|

## Initial Configuration (Switches and Routers)

|Command | Mode | Function | 
|:---|:---|:---|
|hostname abc  | global config | sets hostname to abc |
| enable secret abc | global config | sets encrypted password for priv. EXEC to abc |
| service password-encrypt | global config | encrypts all passwords|
| line console 0 | global config | enters line config mode for console|
| line vty 0 15 | global config | enters line config mode for 16 vty lines|
| password abc | line config | sets line password to abc |
| login | line config | enables users to login |
| interface vlan 1 | global config | enters interface config mode for vlan1 |
| ip address [*ip*] [*subnet*] | interface config | sets IP address |
| no shutdown | interface config | turns on interface |
| banner motd #*TEXT*# | global config | sets motd banner |
