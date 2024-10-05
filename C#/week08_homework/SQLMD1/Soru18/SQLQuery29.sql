SELECT CustomerID,
COUNT(*) AS SiparisMiktari
FROM Orders
GROUP BY CustomerID
HAVING COUNT(CustomerID) >= 5
ORDER BY SiparisMiktari DESC
