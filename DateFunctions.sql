use studentdb;
CREATE TABLE events (
    id INT PRIMARY KEY AUTO_INCREMENT,
    event_name VARCHAR(100),
    event_date DATE
);
INSERT INTO events (event_name, event_date) VALUES
('Music Festival', '2024-05-20'),
('Tech Conference', '2024-08-15'),
('Sports Meet', '2024-11-10'),
('Art Expo', '2025-01-12'),
('Business Summit', '2025-03-05');
SELECT NOW() AS current_datetime;
SELECT 
    event_name,
    DATE_FORMAT(event_date, '%d-%M-%Y') AS formatted_date
FROM events;
SELECT
    event_name,
    YEAR(event_date) AS event_year,
    MONTH(event_date) AS event_month
FROM events;
SELECT 
    CONCAT(event_name, ' scheduled on ', event_date) AS event_details
FROM events;
desc events;