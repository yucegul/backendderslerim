SELECT TOP 5 ProductID, SUM(Quantity) AS Miktar
FROM OrderDetails
GROUP BY ProductID
ORDER BY Miktar DESC