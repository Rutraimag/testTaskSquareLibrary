/*Допустим есть 2 таблицы. Products и Categories. 
В таблице Products: Id, name. 
В таблице Categories: Id, name, productId*/
SELECT Products.name, Categories.name 
FROM Products LEFT JOIN Categories
ON Products.Id = Categories.productId;
