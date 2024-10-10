-- JOINS QUERY 
SELECT 
	username,
	id AS order_id,
	id AS product_id,
	order_name,
	product_name
	
	FROM 
	orders
	INNER JOIN
	products
	INNER JOIN
	users
	ON orders.product_id = products.pdt_id;

	FROM 
	orders 
	RIGHT JOIN
	products
	ON orders.product_id = products.id;