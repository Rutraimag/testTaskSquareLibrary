/*�������� ���� 2 �������. Products � Categories. 
� ������� Products: Id, name. 
� ������� Categories: Id, name, productId*/
SELECT Products.name, Categories.name 
FROM Products LEFT JOIN Categories
ON Products.Id = Categories.productId;