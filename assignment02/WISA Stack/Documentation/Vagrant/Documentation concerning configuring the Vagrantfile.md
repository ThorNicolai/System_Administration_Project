  # The most common configuration options are documented and commented below.
  # For a complete reference, please see the online documentation at
  # https://docs.vagrantup.com.
  
  # Create a private network, which allows host-only access to the machine using a specific IP.
   config.vm.network "private_network", ip: "192.168.56.102"
   
   
  #Automatically there wil be a shared folder from where your Vagrantfile is located on the hostmachine, to "C:\vagrant"
  
  # Share an additional folder to the guest VM. The first argument is
  # the path on the host to the actual folder. The second argument is
  # the path on the guest to mount the folder. And the optional third
  # argument is a set of non-required options.
  # config.vm.synced_folder "../data", "/vagrant_data"
  
  
  #Provisioning: Use an external script that needs to be executed upon launching the Virtual machine
  #More information can be found at: https://www.vagrantup.com/docs/provisioning/shell.html
  #The parameter privileged is set to true, to make sure the script can be executed by the right credentials
  config.vm.provision "shell", path: "Setup_WISA_script.ps1", privileged: true
  
  
  
  Provisioners are run in three cases: the initial vagrant up, vagrant provision, and vagrant reload --provision.

    A --no-provision flag can be passed to up and reload if you do not want to run provisioners. Likewise, you can pass --provision to force provisioning.

    The --provision-with flag can be used if you only want to run a specific provisioner if you have multiple provisioners specified. For example, if you have a shell and Puppet provisioner and only want to run the shell one, you can do vagrant provision --provision-with shell. The arguments to --provision-with can be the provisioner type (such as "shell") or the provisioner name (such as "bootstrap" from above).
    
  For Example: $ vagrant reload --provision
  !!Without it, the script won't be executed after it's first initialization.