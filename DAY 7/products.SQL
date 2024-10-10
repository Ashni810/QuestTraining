CREATE TABLE productDetails(
	pdt_id BIGINT PRIMARY KEY IDENTITY,
	product_name VARCHAR(50),
	description text
)

INSERT INTO products (product_name, Description) VALUES
('Bluetooth Speaker', 'Portable speaker with deep bass and long battery life.'),
('Fitness Tracker', 'Waterproof fitness band with heart rate monitoring.'),
('DSLR Camera Pro', 'High-resolution DSLR camera with interchangeable lenses.'),
('Robot Vacuum', 'Smart vacuum cleaner with automated cleaning and Wi-Fi control.'),
('Air Purifier', 'Compact air purifier with HEPA filter for clean air.');

SELECT * FROM products;