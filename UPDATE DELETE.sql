use studentdb;
CREATE TABLE products (
    id INT PRIMARY KEY,
    name VARCHAR(100),
    price DECIMAL(10,2)
);
ALTER TABLE products
ADD stock INT;
ALTER TABLE products
RENAME COLUMN price TO unit_price;
INSERT INTO products (id, name, unit_price, stock) VALUES
(1, 'Laptop', 55000.00, 10),
(2, 'Mouse', 500.00, 50),
(3, 'Keyboard', 1200.00, 30),
(4, 'Monitor', 8000.00, 15),
(5, 'USB Cable', 150.00, 100);
UPDATE products
SET stock = 20
WHERE id = 2;
DELETE FROM products
WHERE id = 5;
SELECT * FROM products;
desc products;