CREATE TABLE categories(
id INT PRIMARY KEY IDENTITY,
	name varchar(25) NOT NULL UNIQUE,
)



CREATE TABLE product_categories(
	id BIGINT PRIMARY KEY NOT NULL,
	category_id INT,
	product_id BIGINT,

	CONSTRAINT FK_category_id FOREIGN KEY (category_id) REFERENCES categories(id),

	CONSTRAINT FK_prodcut_id FOREIGN KEY (id) REFERENCES products(id)
)