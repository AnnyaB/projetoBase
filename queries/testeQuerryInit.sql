CREATE TABLE categories(
	id INT IDENTITY PRIMARY KEY,
	name VARCHAR(100) NOT NULL
	);

CREATE TABLE products(
	id INT IDENTITY PRIMARY KEY,
	categoryId INT NOT NULL,
	name VARCHAR(100) NOT NULL,
	description VARCHAR(250) NOT NULL,
	price DECIMAL(10,2) NOT NULL,
	stock INT NOT NULL,
	image VARCHAR(250),
	FOREIGN KEY(categoryId) REFERENCES categories(id)
	);

DROP TABLE products

SELECT * 
	FROM products
