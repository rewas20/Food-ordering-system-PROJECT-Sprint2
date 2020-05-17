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

