#!/bin/bash
#
# setup-lamp-stack-on-cent-os-7.sh
#This script should be run as root.
# Sets up a LAMP stack environment using CentOS 7, PHP 5.4, MariaDB 5.5.56, and Apache 2.4.6(httpd) or newer versions.

echo ""
echo "Setting the keyboard layout..."
localectl set-keymap azerty
echo "Starting the installation process."
echo "Installing Apache and setting firewall-rule..."
yum install httpd -y
systemctl start firewalld
systemctl enable firewalld
firewall-cmd --add-service=http --permanent
systemctl start httpd
systemctl restart firewalld
echo "Installing PHP..."
yum install php php-mysql php-pdo php-gd php-mbstring -y
#sudo yum install epel-release -y
#sudo yum install phpmyadmin -t
echo "Installing MariaDB..."
yum install mariadb-server -y
systemctl start mariadb.service


echo "Enabling MySQL and Apache for start on boot..."
sudo systemctl enable mariadb
sudo systemctl enable httpd

echo "The system has set up succesfully."
echo "After logging in to the system, navigate to /vagrant/ and run the configuration.sh script."
#Sort of LAMP installed now.

#sudo wget https://ftp.drupal.org/files/projects/drupal-8.4.5.tar.gz
#tar zxvf drupal-8.4.5.tar.gz
#sudo mv drupal-8.4.5 /var/www/html/
