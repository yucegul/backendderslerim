SELECT Employees.EmployeeID, Employees.FirstName, Employees.LastName
FROM Employees
LEFT JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID
WHERE Orders.OrderID IS NULL;