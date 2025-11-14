
USE studentdb;
CREATE TABLE employees (
    id INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    salary INT DEFAULT 30000,
    email VARCHAR(150)
);
ALTER TABLE employees
ADD CONSTRAINT unique_email UNIQUE (email);
use studentdb;
CREATE TABLE  employees (
    id INT,
    name VARCHAR(100),
    price INT
);
ALTER TABLE  employees
ADD stock INT;
ALTER TABLE  employees
RENAME COLUMN price TO unit_price;
