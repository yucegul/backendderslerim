SELECT Products.ProductName, Categories.CategoryName
FROM Products
JOIN Categories on Products.CategoryID = Categories.CategoryID
ORDER BY Products.CategoryID