CREATE TABLE userdata(
	user_id BIGINT IDENTITY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	username VARCHAR(25) NOT NULL,
	email VARCHAR(100) NOT NULL,
	phone_number VARCHAR(20),
	dob DATETIME,
	password_hash VARCHAR(250),	
	about TEXT
);

ALTER TABLE userdata ADD CONSTRAINT PK_users_id PRIMARY KEY (user_id);

ALTER TABLE userdata ADD CONSTRAINT users_username UNIQUE (username)

ALTER TABLE userdata ADD CONSTRAINT UQ_users_email UNIQUE (email)

CREATE INDEX IX_users_phone ON userdata (phone_number)

ALTER TABLE userdata ADD CONSTRAINT CHK_users_phone CHECK (LEN(phone_number) BETWEEN 7 AND 20)

ALTER TABLE userdata ADD CONSTRAINT CHK_users_dob CHECK (dob < GETDATE())

INSERT INTO userdata (first_name, last_name, username, email, phone_number, dob, password_hash, about) VALUES
('Frank', 'Wilson', 'fwilson', 'frankw@example.com', '555-3456', '1991-11-22', 'hash104', 'Software engineer.'),
('Grace', 'Lee', 'glee', 'gracel@example.com', '555-6543', '1994-06-15', 'hash105', 'Loves cooking and baking.'),
('Henry', 'Taylor', 'htaylor', 'henryt@example.com', '555-8769', '1996-10-05', 'hash106', 'Photography enthusiast.'),
('Ivy', 'Harris', 'iharris', 'ivyh@example.com', '555-6547', '1990-08-08', 'hash107', 'Enjoys outdoor adventures.');