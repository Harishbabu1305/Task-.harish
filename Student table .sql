CREATE DATABASE studentdb;
USE studentdb;
CREATE TABLE student (
     id INT AUTO_INCREMENT PRIMARY KEY,
     name varchar(30),
     age INT,
     grade varchar(10)
);
desc student;