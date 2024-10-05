SELECT 
YEAR(OrderDate) AS Year, 
MONTH(OrderDate) AS Month,
SUM(OrderDetails.UnitPrice * OrderDetails.Quantity * (1 - OrderDetails.Discount)) AS TotalSales
FROM Orders
JOIN OrderDetails ON Orders.OrderID =OrderDetails.OrderID
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY Year, Month;