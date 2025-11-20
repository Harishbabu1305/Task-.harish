use studentdb;
CREATE TABLE employees (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    department VARCHAR(50),
    salary INT
);
INSERT INTO employees VALUES
(1, 'John', 'HR', 40000),
(2, 'Sara', 'IT', 55000),
(3, 'Mike', 'Finance', 60000),
(4, 'Rita', 'IT', 65000);

CREATE VIEW IT_Employees AS
SELECT id, name, salary
FROM employees
WHERE department = 'IT';
SELECT * FROM IT_Employees;
CREATE VIEW Employee_Salary_View AS
SELECT id, name, salary
FROM employees;
UPDATE Employee_Salary_View
SET salary = salary + 5000
WHERE id = 2;   -- Updates Sara's salary in main table
SELECT * FROM employees;
SELECT * FROM Employee_Salary_View;
desc employees;