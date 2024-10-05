SELECT SupplierID, AVG(UnitPrice) AS ORTALAMA
FROM Products
WHERE UnitsInStock > 10
GROUP BY SupplierID

