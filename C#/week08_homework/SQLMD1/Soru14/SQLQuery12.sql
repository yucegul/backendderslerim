SELECT Customers.ContactName, Orders.CustomerID,
COUNT(*) AS Sayi
FROM Orders
JOIN Customers ON Orders.CustomerID = Customers.CustomerID
GROUP BY Orders.CustomerID, Customers.ContactName
ORDER BY Sayi DESC
