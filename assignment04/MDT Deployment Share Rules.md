### MDT Deployment Share Rules

### [Settings]  
	Priority=Default

### [Default]    
	OSInstall=Y  
	SkipProductKey=YES
	SkipComputerName=YES
	SkipDomainMembership=YES
	AdminPassword=Admin1
	UserDataLocation=AUTO
	SkipLocaleSelection=YES
	SkipTaskSequence=NO
	DeploymentType=NEWCOMPUTER
	SkipTimeZone=YES
	JoinWorkgroup=WORKGROUP
	SkipApplications=NO 
	SkipBitLocker=YES  
	SkipSummary=YES  
	SkipBDDWelcome=YES
	SkipCapture=NO
	DoCapture=NO
	SkipFinalSummary=NO
	UILanguage=0813:00000813  
	InputLocale=0813:00000813
	SystemLocale=0813:00000813  
	UserLocale=0813:00000813 
	KeyboardLocale=0813:00000813
	DoNotCreateExtraPartition = YES

	TimeZone=105  
	TimeZoneName=Romance Standard Time
