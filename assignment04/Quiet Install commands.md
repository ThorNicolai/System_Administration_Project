### General Quiet install command

msiexec /i **c:\path\to\package.msi** /quiet /qn /norestart

### Add log file if needed

 /log **c:\path\to\install.log**


### Java Application

We ran into some trouble running the java application with the general command.

This is the alternate command found [here](http://www.edugeek.net/forums/enterprise-software/143767-java-8-update-25-silent-install-via-sccm.html)

    msiexec /i jre1.8.0_25.msi AUTO_UPDATE=0 EULA=0 NOSTARTMENU=1 SPONSORS=0 WEB_ANALYTICS=0 WEB_JAVA=1 WEB_JAVA_SECURITY_LEVEL=H /qb
