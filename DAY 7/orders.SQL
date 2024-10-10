CREATE TABLE orders (
	order_id BIGINT PRIMARY KEY IDENTITY,
	quantity INT NOT NULL DEFAULT 1,
    product_id BIGINT NOT NULL,
    user_id BIGINT NOT NULL,

    CONSTRAINT FK_orders_product_id FOREIGN KEY (product_id) REFERENCES productDetails(pdt_id),
    CONSTRAINT FK_orders_user_id FOREIGN KEY (user_id) REFERENCES userdata(user_id)
)


INSERT INTO orders (quantity, product_id, user_id) VALUES
(2, 1, 1),
(1, 2, 2),
(3, 3, 3),
(1, 4, 4),
(5, 5, 5),
(2, 6, 6);


DROP TABLE orders;