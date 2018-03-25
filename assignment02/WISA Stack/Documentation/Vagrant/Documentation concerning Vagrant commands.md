#To give a list with all the available commands in the vagrant tool
$ vagrant list-commands 

The most important ones that will be used the most are:
$ vagrant init -> initializes a new Vagrant environment by creating a Vagrantfile (where further configurations can be made)
$ vagrant halt -> stops the vagrant machine
$ vagrant reload -> realoads the vagrant machine
$ vagrant up -> starts and provisions the target environment
$ vagrant ssh -> connects to the machine via SSH (For UNIX based OS, for Windows it's better to use PuTTY)
$ vagrant package -> packages a running vagrant environment into a box