SELECT CustomerID, COUNT(DISTINCT ProductID) AS Miktar,
SUM(UnitPrice * Quantity * (1 - Discount)) AS Satis
FROM Orders
JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID
GROUP BY CustomerID
HAVING COUNT(DISTINCT ProductID) >= 5 
AND SUM(UnitPrice * Quantity * (1 - Discount)) > 10000;