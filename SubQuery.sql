use studentdb;
SELECT *
FROM employees
WHERE salary > (SELECT AVG(salary) FROM employees);
SELECT *
FROM products
WHERE price > (
    SELECT MIN(price)
    FROM orders
);
SELECT *
FROM customers
WHERE id IN (
    SELECT customer_id
    FROM orders
);
SELECT 
    c.id,
    c.name,
    (SELECT COUNT(*)
     FROM orders o
     WHERE o.customer_id = c.id) AS order_count
FROM customers c;
SELECT 
    CASE 
        WHEN EXISTS (SELECT 1 FROM products WHERE name = 'Laptop')
        THEN 'Product Exists'
        ELSE 'Product Not Found'
    END AS result;
    desc employees;
    