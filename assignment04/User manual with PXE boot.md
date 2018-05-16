# Deploy a workstation

## Prerequisites

 - A Windows Server with all the necessary features is available, click  [here](https://github.com/HoGentTIN/p2ops-i01/blob/master/assignment04/Documentation/Set%20up%20Windows%20Server.md) for a guide
- A deployable Windows Image is configured using MDT, click [
here](https://github.com/HoGentTIN/p2ops-i01/blob/master/assignment04/Documentation/2.%20Set%20up%20Windows10%20image%20%28MDT%29.md) for a guide
- All settings are configured for PXE in Windows Deployment Services, click [here](https://github.com/HoGentTIN/p2ops-i01/blob/master/assignment04/Documentation/3.%20Configure%20WDS%20for%20PXE.md) for a guide

## Booting a workstation

> Since the workstation will be inside the DHCP pool you will be able to boot of the PXE server using this method.

- When you first boot your workstation, press F12 when the menu pops up to choose a medium, press L to boot from LAN.
- PXE will be shown and your device will boot using the correct image if defaults were configured correctly.
- Once you enter the first boot you will need to go through a credential check (Administrator or predefined Users) and after that there won't be any user interaction needed

Click [here](https://youtu.be/a_5ZYozHVUE) to see a video of a fresh boot.
