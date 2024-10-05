USE Northwind
GO

SELECT Country,
COUNT(*) AS Ulke
FROM Customers
GROUP BY Country
ORDER BY Ulke DESC