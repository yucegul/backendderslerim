SELECT Categories.CategoryName,Categories.CategoryID, AVG(Products.UnitPrice)
FROM Products
JOIN Categories ON Products.CategoryID = Categories.CategoryID
GROUP BY Categories.CategoryName,Categories.CategoryID
