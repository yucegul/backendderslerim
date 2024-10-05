USE Northwind
GO

SELECT CategoryID,
COUNT(*) AS Kategori
FROM Products
GROUP BY CategoryID