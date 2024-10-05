SELECT ProductID, COUNT(DISTINCT CustomerID) AS Benzersiz
FROM OrderDetails
JOIN Orders ON OrderDetails.OrderID = Orders.OrderID
GROUP BY ProductID;