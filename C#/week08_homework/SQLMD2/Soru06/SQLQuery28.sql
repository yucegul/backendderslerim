SELECT Employees.EmployeeID,Employees.FirstName,Employees.LastName,SUM(OrderDetails.UnitPrice * OrderDetails.Quantity * (1-OrderDetails.Discount)) AS Satis
FROM Orders
JOIN EmployeeTerritories ON Orders.EmployeeID = EmployeeTerritories.EmployeeID
JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID
JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
JOIN Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID
GROUP BY Employees.EmployeeID,Employees.FirstName,Employees.LastName
ORDER BY Satis
