SELECT
	Products.Name AS ProductName,
	Categories.Name AS CategoryName
FROM Products AS Products
	LEFT JOIN Categories AS Categories
	ON Products.Id = Categories.ProductId