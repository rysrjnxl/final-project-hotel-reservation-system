DROP DATABASE IF EXISTS hotel_db;
CREATE DATABASE hotel_db;
USE hotel_db;
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50),
    password VARCHAR(50),
    role VARCHAR(20) DEFAULT 'Staff'
);

INSERT INTO users (username, password, role) VALUES ('admin', 'admin123', 'Manager');

CREATE TABLE guests (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE,
    full_name VARCHAR(100),
    email VARCHAR(100),
    phone VARCHAR(20),
    password VARCHAR(50) DEFAULT '12345'
);

CREATE TABLE rooms (
    id INT AUTO_INCREMENT PRIMARY KEY,
    room_number VARCHAR(10),
    room_type VARCHAR(50),
    price DECIMAL(10, 2),
    status VARCHAR(20) DEFAULT 'Available'
);

CREATE TABLE staff (
    id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(100), 
    position VARCHAR(50),
    phone VARCHAR(20)
);

CREATE TABLE reservations (
    id INT AUTO_INCREMENT PRIMARY KEY,
    guest_id INT,
    room_id INT,
    check_in DATE,
    check_out DATE,
    total_amount DECIMAL(10,2),
    FOREIGN KEY (guest_id) REFERENCES guests(id),
    FOREIGN KEY (room_id) REFERENCES rooms(id)
);

CREATE TABLE cleaning_tasks (
    id INT AUTO_INCREMENT PRIMARY KEY,
    room_id INT,
    staff_id INT,
    status VARCHAR(50),
    FOREIGN KEY (room_id) REFERENCES rooms(id),
    FOREIGN KEY (staff_id) REFERENCES staff(id)
);

SELECT * FROM guests;

USE hotel_db;

SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE cleaning_tasks;
TRUNCATE TABLE reservations;
TRUNCATE TABLE guests;
TRUNCATE TABLE rooms;
TRUNCATE TABLE staff;
TRUNCATE TABLE users;
SET FOREIGN_KEY_CHECKS = 1;

INSERT INTO users (username, password, role) VALUES 
('admin', 'admin123', 'Administrator'),
('manager', 'manager123', 'Manager'),
('reception', 'staff123', 'Staff');

INSERT INTO staff (full_name, position, phone) VALUES 
('Sarah Connor', 'Manager', '0917-111-1111'),
('Kyle Reese', 'Security', '0917-222-2222'),
('Ellen Ripley', 'Receptionist', '0917-333-3333'),
('Arthur Dent', 'Cleaner', '0917-444-4444'),
('Ford Prefect', 'Cleaner', '0917-555-5555');

INSERT INTO rooms (room_number, room_type, price, status) VALUES 
('101', 'Single', 5000.00, 'Available'),
('102', 'Single', 5000.00, 'Occupied'),
('103', 'Single', 5000.00, 'Maintenance'),
('201', 'Double', 10000.00, 'Available'),
('202', 'Double', 10000.00, 'Available'),
('203', 'Double', 10000.00, 'Occupied'),
('301', 'Suite', 20000.00, 'Available'),
('302', 'Suite', 20000.00, 'Available');

INSERT INTO guests (username, full_name, email, phone, password) VALUES 
('johnwick', 'John Wick', 'john@continental.com', '0917-000-0001', 'dog123'),
('jamesbond', 'James Bond', '007@mi6.gov.uk', '0917-007-0007', 'skyfall'),
('laracroft', 'Lara Croft', 'lara@tomb.com', '0917-888-9999', '12345'),
('tonystark', 'Tony Stark', 'tony@stark.com', '0917-iron-man', 'jarvis');

INSERT INTO reservations (guest_id, room_id, check_in, check_out, total_amount) 
VALUES (
    (SELECT id FROM guests WHERE username='johnwick'),
    (SELECT id FROM rooms WHERE room_number='102'),
    CURDATE(), DATE_ADD(CURDATE(), INTERVAL 3 DAY), 4500.00
);

INSERT INTO reservations (guest_id, room_id, check_in, check_out, total_amount) 
VALUES (
    (SELECT id FROM guests WHERE username='jamesbond'),
    (SELECT id FROM rooms WHERE room_number='203'),
    '2023-12-01', '2023-12-05', 10000.00
);

INSERT INTO cleaning_tasks (room_id, staff_id, status) VALUES 
((SELECT id FROM rooms WHERE room_number='103'), (SELECT id FROM staff WHERE full_name='Arthur Dent'), 'In Progress'),
((SELECT id FROM rooms WHERE room_number='203'), (SELECT id FROM staff WHERE full_name='Ford Prefect'), 'Pending'),
((SELECT id FROM rooms WHERE room_number='301'), (SELECT id FROM staff WHERE full_name='Arthur Dent'), 'Completed');

SELECT * FROM users;
SELECT * FROM guests;
SELECT * FROM rooms;
SELECT * FROM reservations;