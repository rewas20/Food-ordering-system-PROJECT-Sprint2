Create table Category
(
id int identity primary key,
name nvarchar(50) not null,
number_of_products int not null,
);
Create table Product
(
id int identity primary key,
name nvarchar(50) not null,
price Float NOT NULL,
image nvarchar(max) not null,
description nvarchar(max) not null,
category_id int not null,
CONSTRAINT FK_CategoryId FOREIGN KEY (category_id) REFERENCES Category(id)
);

CREATE TABLE Cart (
    item_id INT primary key,
    product_id int not null,
    added_at   DATETIME NULL,
    userId  INT    NULL,
    countProduct int default 1,
    CONSTRAINT FK_ProductId FOREIGN KEY (product_id) REFERENCES Product(id),
	
);
