SELECT CustomerID, OrderDate,
COUNT(OrderID) AS SiparisSayisi
FROM Orders
GROUP BY CustomerID, OrderDate
HAVING COUNT(OrderID) > 1;