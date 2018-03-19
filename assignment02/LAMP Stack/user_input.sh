#! /bin/sh
#
# Author: Bert Van Vreckem <bert.vanvreckem@gmail.com>
#
# A non-interactive replacement for mysql_secure_installation
#
# Tested on CentOS 6, CentOS 7, Ubuntu 12.04 LTS (Precise Pangolin), Ubuntu
# 14.04 LTS (Trusty Tahr).

set -o errexit # abort on nonzero exitstatus
set -o nounset # abort on unbound variable

#{{{ Functions

usage() {
cat << _EOF_

Usage: ${0} "ROOT PASSWORD"

  with "ROOT PASSWORD" the desired password for the database root user.

Use quotes if your password contains spaces or other special characters.
_EOF_
}

# Predicate that returns exit status 0 if the database root password
# is set, a nonzero exit status otherwise.
is_mysql_root_password_set() {
  ! mysqladmin --user=root status > /dev/null 2>&1
}

# Predicate that returns exit status 0 if the mysql(1) command is available,
# nonzero exit status otherwise.
is_mysql_command_available() {
  which mysql > /dev/null 2>&1
}

#}}}
#{{{ Command line parsing

#if [ "$#" -ne "2" ]; then
#  echo "Expected 2 arguments, got $#" >&2
#  usage
#  exit 2
#fi

#}}}
#{{{ Variables
#db_root_password="${1}"
#db_name="${2}"
#}}}

# Ask for user INPUT
read -p 'Please provide a root password for MySQL: ' db_root_password
read -p 'Please provide a database name: ' db_name
read -p 'Please provide a username for MySQL: ' username
read -p 'Please provide a password for the new user: ' password

# Script proper

if ! is_mysql_command_available; then
  echo "The MySQL/MariaDB client mysql(1) is not installed."
  exit 1
fi

if is_mysql_root_password_set; then
  echo "Database root password already set"
  exit 0
fi

mysql --user=root <<_EOF_
  UPDATE mysql.user SET Password=PASSWORD('${db_root_password}') WHERE User='root';
  DELETE FROM mysql.user WHERE User='';
  DELETE FROM mysql.user WHERE User='root' AND Host NOT IN ('localhost', '127.0.0.1', '::1');
  DROP DATABASE IF EXISTS test;
  DELETE FROM mysql.db WHERE Db='test' OR Db='test\\_%';
  FLUSH PRIVILEGES;
  CREATE DATABASE ${db_name};
  CREATE USER '${username}'@'localhost' IDENTIFIED BY '${password}';
  GRANT ALL PRIVILEGES ON * . * TO '${username}'@'localhost';
  FLUSH PRIVILEGES;
_EOF_

# This is for testing purposes only.
if [ -f "/vagrant/sqltest.php" ]
then
	sed -i '1 i\$dbname = '\"${db_name}'";' /vagrant/sqltest.php
	sed -i '1 i\$dbuser = '\"${username}'";' /vagrant/sqltest.php
	sed -i '1 i\$dbpass = '\"${password}'";' /vagrant/sqltest.php
	sed -i '1 i\$dbhost = \"localhost";' /vagrant/sqltest.php
	sed -i '1 i\<?php' /vagrant/sqltest.php
	cp /vagrant/sqltest.php /var/www/html
	sudo service httpd restart
fi
