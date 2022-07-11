CREATE TABLE Product
(
	Id int,
	Title varchar (50)
);
GO

CREATE TABLE Category
(
	Id int,
	Title varchar(50)
);
GO

CREATE TABLE PC
(
	Product int,
	Category int
);
GO

INSERT Product
VALUES	(1, '–учка Parker'),
		(2, 'Powerbank'),
		(3, 'Ѕлокнот с обложкой из пробки'),
		(4, 'јааавтомобиль!')

INSERT Category
VALUES	(1, 'ƒеловые аксесуары'),
		(2, 'Ёко'),
		(3, 'VIP'),
		(4, 'Ёлетроника'),
		(5, 'ѕишущие принадлежности')

INSERT PC
VALUES	(1, 1),
		(1, 3),
		(1, 5),
		(2, 4),
		(3, 2),
		(3, 1)

SELECT Product.Title AS "Product Name" , Category.Title AS "Category Name"
		FROM Product
		LEFT JOIN PC ON PC.Product = Product.Id
		LEFT JOIN Category ON Category.Id = PC.Category
		GROUP BY Product.Title, Category.Title
GO