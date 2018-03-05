yum install httpd
sudo firewall-cmd --add-service=http --permanent
systemctl restart firewalld
yum install php php-mysql php-pdo php-gd php-mbstring -y
sudo yum install epel-release
sudo yum install phpmyadmin
sudo systemctl enable mariadb
sudo systemctl enable httpd

--Sort of LAMP installed now. 

#sudo wget https://ftp.drupal.org/files/projects/drupal-8.4.5.tar.gz
#tar zxvf drupal-8.4.5.tar.gz 
#sudo mv drupal-8.4.5 /var/www/html/

