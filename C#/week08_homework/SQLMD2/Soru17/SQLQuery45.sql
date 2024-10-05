SELECT Shippers.CompanyName, AVG(Orders.Freight) AS AverageFreight
FROM Orders
JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID
GROUP BY Shippers.CompanyName;