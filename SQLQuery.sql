/*
Products - таблица с продуктами
Categories - таблица с категориями
ProductCategories - связующая таблица для отношения "многие ко многим"
*/

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
