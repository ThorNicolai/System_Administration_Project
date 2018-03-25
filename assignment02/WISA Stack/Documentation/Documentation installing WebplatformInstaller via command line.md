1. Install WebplatformInstaller:
  mkdir c:\webdeployv2 -Force
    (New-Object Net.WebClient).DownloadFile('https://download.microsoft.com/download/C/F/F/CFF3A0B8-99D4-41A2-AE1A-496C08BEB904/WebPlatformInstaller_amd64_en-US.msi','C:\webdeployv2\WebPlatformInstalleramd64_en-US.msi')
    
    msiexec /i "C:\webdeploy\WebPlatformInstaller_amd64_en-US.msi" /qr
    
2.  Run to see all the available products to install:
"C:\Program Files\Microsoft\Web Platform Installer\WebPICMD-x64.exe" /List /ListOption:all

3.  To install use parameters /Install /Products:"..."
for example: WebPICMD-x64.exe/Install /Products:MVC3,WebMatrix OR in powershell WebPICMD-x64.exe/Install /Products:"MVC3,WebMatrix"

Further information can be found at: https://docs.microsoft.com/en-us/iis/install/web-platform-installer/web-platform-installer-v4-command-line-webpicmdexe-rtw-release