SELECT Orders.OrderID, Shippers.CompanyName
FROM Orders
JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID
