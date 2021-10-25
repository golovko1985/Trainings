/* tested on mySQL */

/* create tables */

DROP SCHEMA IF EXISTS TestProductCategory;
CREATE SCHEMA TestProductCategory;
USE TestProductCategory;

CREATE TABLE Product (
	Product_ID    INTEGER NOT NULL UNIQUE,
	Product_Name  VARCHAR(20) NOT NULL,
	PRIMARY KEY (Product_ID)
);

CREATE TABLE Category (
	Category_ID    INTEGER NOT NULL UNIQUE,
	Category_Name  VARCHAR(20) NOT NULL,
	PRIMARY KEY (Category_ID)
);

CREATE TABLE Product_category (
	Product_ID    INTEGER NOT NULL,
	Category_ID   INTEGER NOT NULL,
	PRIMARY KEY (Product_ID, Category_ID)
);

/* insert tuples */
INSERT INTO Category
VALUES
	(1, 'Vegetables'),
	(2, 'Drinks'),
	(3, 'Fruits');
	
INSERT INTO Product
VALUES
	(1, 'cucumber'),
	(2, 'carrot'),
	(3, 'tomato'),
	(4, 'Apple'),
	(5, 'Pear'),
	(6, 'Coca-cola'),
	(7, 'Computer');

INSERT INTO Product_category
VALUES
	(1, 1),
	(2, 1),
	(3, 1),
	(3, 2),
	(4, 2),
	(5, 2),
	(6, 3);

/*
    SQL query to select all pairs "Product name - Category name".
    If the product has no categories, then its name should still be displayed.
*/

SELECT Product.Product_Name, Category_Name
FROM Product
LEFT JOIN Product_category ON Product.Product_ID = Product_category.Product_ID
LEFT JOIN category ON Product_category.Category_ID = Category.Category_ID;

