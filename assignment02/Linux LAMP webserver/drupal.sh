#!/bin/bash
#
# Description: Installing Drupal
# Might need to add "AllowOverride All" in the httpd.conf file
# otherwise Drupal won't be able to serve files.

echo "If you get errors running this file, clean it with dos2unix."
yum install wget -y
wget http://ftp.drupal.org/files/projects/drupal-8.5.0.tar.gz
tar zxvf drupal-8.5.0.tar.gz
mv drupal-8.5.0 /var/www/html
cd /var/www/html/drupal-8.5.0/
cp sites/default/default.settings.php sites/default/settings.php
chmod a+w sites/default/settings.php
chmod a+w sites/default



# Drupal Permissions and Context
chown -R apache:apache /var/www/html
chcon -R -t httpd_sys_rw_content_t /var/www/html/drupal-8.5.0/sites/
restorecon -r /var/www/html
# Install Drush
# pear channel-discover pear.drush.org
# pear install drush/drush
