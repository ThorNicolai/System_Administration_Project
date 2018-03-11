#! /bin/sh
#
# Author: Bert Van Vreckem <bert.vanvreckem@gmail.com>
#
# A non-interactive replacement for mysql_secure_installation
#
# Tested on CentOS 6, CentOS 7, Ubuntu 12.04 LTS (Precise Pangolin), Ubuntu
# 14.04 LTS (Trusty Tahr).

# Ask for user INPUT
read -p 'Please provide a root password for MySQL: ' db_root_password
read -p 'Please provide a database name: ' db_name
read -p 'Please provide a username for MySQL: ' username
read -p 'Please provide a password for the new user: ' password

mysql --user=root <<_EOF_
  CREATE DATABASE ${db_name};
  CREATE USER '${username}'@'localhost' IDENTIFIED BY '${password}';
  GRANT ALL PRIVILEGES ON * . * TO '${username}'@'localhost';
  FLUSH PRIVILEGES;
_EOF_
