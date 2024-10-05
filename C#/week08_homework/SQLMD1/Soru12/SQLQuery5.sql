SELECT OrderID, SUM(UnitPrice * Quantity * (1 - Discount)) AS Miktar
FROM [OrderDetails]
GROUP BY OrderID;