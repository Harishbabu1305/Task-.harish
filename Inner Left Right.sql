use studentdb;
CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    customer_name VARCHAR(100),
    city VARCHAR(50)
);
CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    customer_id INT,
    product_name VARCHAR(100),
    amount DECIMAL(10,2),
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);
INSERT INTO customers (customer_id, customer_name, city) VALUES
(1, 'Arun', 'Chennai'),
(2, 'Meena', 'Mumbai'),
(3, 'Ravi', 'Delhi'),
(4, 'Kiran', 'Bangalore'),
(5, 'Sita', 'Hyderabad');
INSERT INTO orders (order_id, customer_id, product_name, amount) VALUES
(101, 1, 'Laptop', 55000),
(102, 2, 'Mobile', 15000),
(103, 1, 'Keyboard', 1200),
(104, 4, 'Monitor', 8000),
(105, 2, 'Mouse', 500);
SELECT 
    customers.customer_name,
    orders.product_name,
    orders.amount
FROM customers
INNER JOIN orders
ON customers.customer_id = orders.customer_id;
SELECT 
    customers.customer_name,
    orders.product_name,
    orders.amount
FROM customers
LEFT JOIN orders
ON customers.customer_id = orders.customer_id;
desc customers ;