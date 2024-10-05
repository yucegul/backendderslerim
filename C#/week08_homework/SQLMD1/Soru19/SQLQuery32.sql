SELECT Orders.ShipCountry, SUM(OrderDetails.UnitPrice * OrderDetails.Quantity * (1-OrderDetails.Discount)) AS Tutar
FROM Orders
JOIN OrderDetails on Orders.OrderID = OrderDetails.OrderID
GROUP BY Orders.ShipCountry
ORDER BY Tutar DESC