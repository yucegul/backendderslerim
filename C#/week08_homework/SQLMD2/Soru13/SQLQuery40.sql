SELECT Orders.ShipCountry, SUM(OrderDetails.UnitPrice * OrderDetails.Quantity * (1-OrderDetails.Discount)) AS Satis
FROM
Orders
JOIN OrderDetails on Orders.OrderID = OrderDetails.OrderID
GROUP BY Orders.ShipCountry
HAVING SUM(OrderDetails.UnitPrice * OrderDetails.Quantity * (1-OrderDetails.Discount)) > 5000
