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
#Devnote: CentOS standard php installation is 5.4, which is outdated
#and can't be used with Drupal 8.5. We need ius to install
#newer versions.
curl 'https://setup.ius.io/' -o setup-ius.sh
bash setup-ius.sh
yum install mod_php56u php56u-cli php56u-mysqlnd php56u-gd -y
#sudo yum install epel-release -y
#sudo yum install phpmyadmin -t

echo "Installing MariaDB..."
yum install mariadb-server -y
systemctl start mariadb.service


echo "Enabling MySQL and Apache for start on boot..."
sudo systemctl enable mariadb
sudo systemctl enable httpd

echo "The system has set up succesfully."
echo "After logging in to the system, navigate to /vagrant/ and run the user_input.sh script."
