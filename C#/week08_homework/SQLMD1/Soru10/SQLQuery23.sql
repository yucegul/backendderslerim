USE Northwind
GO

SELECT Employees.FirstName, Employees.LastName, Orders.EmployeeID,
COUNT(*) AS Sayi
FROM Orders
JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
GROUP BY Orders.EmployeeID, Employees.EmployeeID, Employees.FirstName, Employees.LastName
ORDER BY Sayi DESC
