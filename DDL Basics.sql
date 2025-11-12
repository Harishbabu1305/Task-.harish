
USE studentdb;
CREATE TABLE products (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name varchar(30),
  price decimal(10,2)
);
alter table products
add column stock INT;
ALTER TABLE products
RENAME COLUMN price TO unit_price;
desc products;

           