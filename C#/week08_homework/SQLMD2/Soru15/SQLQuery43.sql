SELECT EmployeeID, AVG(DATEDIFF(DAY, RequiredDate, ShippedDate)) AS Gecikme
FROM Orders
WHERE ShippedDate IS NOT NULL
GROUP BY EmployeeID;