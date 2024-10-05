SELECT Employees.EmployeeID,Employees.FirstName, Employees.LastName,
SUM(OrderDetails.UnitPrice * OrderDetails.Quantity * (1 - OrderDetails.Discount)) AS SatisMiktari
FROM Orders
JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID
GROUP BY Employees.EmployeeID, Employees.FirstName, Employees.LastName 