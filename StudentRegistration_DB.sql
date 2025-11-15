use  studentdb;
CREATE TABLE orders (
    id INT PRIMARY KEY,
    product_name VARCHAR(100) NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(10,2) NOT NULL
);

INSERT INTO orders (id, product_name, quantity, price) VALUES
(1, 'Laptop', 2, 55000.00),
(2, 'Mouse', 5, 499.00),
(3, 'Keyboard', 3, 1200.00),
(4, 'Monitor', 1, 8999.00),
(5, 'Headset', 4, 1999.00);

SELECT * FROM orders;
desc student;