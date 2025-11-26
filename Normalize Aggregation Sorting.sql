use studentdb;
CREATE TABLE Orders (
    order_id INT PRIMARY KEY,
    customer_name VARCHAR(50)
);
CREATE TABLE Order_Items (
    order_id INT,
    product_name VARCHAR(50),
    FOREIGN KEY (order_id) REFERENCES Orders(order_id)
);
INSERT INTO Orders VALUES
(1, 'Arjun'),
(2, 'Meena');
INSERT INTO Order_Items VALUES
(1, 'Laptop'),
(1, 'Mouse'),
(1, 'Keyboard'),
(2, 'Phone'),
(2, 'Charger');
CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    student_name VARCHAR(50),
    pincode INT
);
CREATE TABLE Locations (
    pincode INT PRIMARY KEY,
    city VARCHAR(50),
    state VARCHAR(50)
);
INSERT INTO Students VALUES
(1, 'Karan', 600001),
(2, 'Priya', 600002);
INSERT INTO Locations VALUES
(600001, 'Chennai', 'Tamil Nadu'),
(600002, 'Madurai', 'Tamil Nadu');
CREATE TABLE ProductOrders (
    order_id INT,
    product_name VARCHAR(50),
    price DECIMAL(10,2)
);
INSERT INTO ProductOrders VALUES
(1, 'Laptop', 50000),
(2, 'Mouse', 500),
(3, 'Keyboard', 1500),
(4, 'Laptop', 52000),
(5, 'Mouse', 600);
SELECT AVG(price) AS avg_order_price
FROM ProductOrders;
SELECT product_name, SUM(price) AS total_sales
FROM ProductOrders
GROUP BY product_name;
SELECT product_name, SUM(price) AS total_sales
FROM ProductOrders
GROUP BY product_name
ORDER BY total_sales DESC;
desc Orders;