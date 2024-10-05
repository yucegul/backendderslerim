SELECT TOP 1 MONTH(OrderDate)AS Ay,SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) AS Ciro
FROM Orders o
JOIN OrderDetails od ON o.OrderID = od.OrderID
WHERE YEAR(ORDERDATE) = 1997
GROUP BY MONTH(OrderDate)
ORDER BY Ciro DESC
