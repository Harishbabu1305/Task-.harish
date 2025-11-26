use studentdb;
CREATE TABLE Orders (
    id INT PRIMARY KEY,
    product_name VARCHAR(50),
    quantity INT,
    price DECIMAL(10,2)
);
INSERT INTO Orders VALUES
(1, 'Apple Juice', 3, 120),
(2, 'Banana Shake', 1, 80),
(3, 'Almond Milk', 5, 350),
(4, 'Avocado Salad', 2, 250),
(5, 'Mango Lassi', 4, 150);
SELECT * 
FROM Orders
WHERE quantity > 2;
SELECT *
FROM Orders
WHERE price BETWEEN 100 AND 500;
SELECT *
FROM Orders
WHERE product_name LIKE 'A%';
SELECT *
FROM Orders
ORDER BY quantity DESC;
CREATE TABLE Events (
    event_id INT PRIMARY KEY,
    event_name VARCHAR(50),
    event_date DATE
);
INSERT INTO Events VALUES
(1, 'Diwali Festival', '2025-11-01'),
(2, 'New Year Party', '2025-12-31');
SELECT 
    CONCAT(event_name, ' - ', event_date) AS event_details
FROM Events;
desc Orders;