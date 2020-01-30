USE MIDDLE_EAST_ART_MUSEUM

SELECT s.SCVisitorNumber, s.Department, v.VisitorName
FROM Student_T s
INNER JOIN Visitor_T v on s.SCVisitorNumber = v.VisitorNumber;

SELECT c.CVisitorNumber, c.IDNumber, v.VisitorName, v.Age
FROM Citizen_T c
INNER JOIN Visitor_T v on c.CVisitorNumber = v.VisitorNumber;

SELECT a.Job, a.Company, v.VisitorName
FROM Adult_T a
INNER JOIN Visitor_T v on a.ACVisitorNumber = v.VisitorNumber;

SELECT COUNT(*) FROM Employee_T
	WHERE EmployeeAddress = 'Keçiören';

SELECT VisitorNumber, VisitorName, Age
	FROM Visitor_T
		WHERE VisitorNumber IN 
		(SELECT ACVisitorNumber FROM Adult_T)
		ORDER BY Age, VisitorName


SELECT Item_T.Barcode, Item_T.ItemName, Item_T.ItemDescription, Item_T.Price, Shops_Items_T.ShopName
FROM Item_T, Shops_Items_T
WHERE Item_T.Barcode = Shops_Items_T.Barcode
	AND Shops_Items_T.ShopName = 'Güneþ Market'
ORDER BY Item_T.ItemName
--These two are the same with different syntax
SELECT Item_T.Barcode, Item_T.ItemName, Item_T.ItemDescription, Item_T.Price, Shops_Items_T.ShopName
FROM Item_T INNER JOIN Shops_Items_T ON 
	Item_T.Barcode = Shops_Items_T.Barcode
	AND Shops_Items_T.ShopName = 'Güneþ Market'
ORDER BY Item_T.ItemName

SELECT DISTINCT ItemName, ItemDescription
FROM Item_T 
WHERE EXISTS
	(SELECT * FROM Book_T
		WHERE BBarcode = Item_T.Barcode
			AND Genre = 'World Literature'
			AND Item_T.Price < 25);
		
SELECT PieceType, COUNT(PieceType)
	FROM Piece_T
		GROUP BY PieceType

SELECT PieceType, COUNT(PieceType)
	FROM Piece_T
		GROUP BY PieceType
		HAVING COUNT(PieceType) > 2

--Union
SELECT VisitorName, 'Oldest' AS Attribute, Age
FROM Visitor_T
	WHERE Age = (SELECT MAX(Age) FROM Visitor_T)
UNION
SELECT VisitorName, 'Youngest' AS Attribute, Age
FROM Visitor_T
	WHERE Age = (SELECT MIN(Age) FROM Visitor_T)

SELECT Shop_T.ShopName, Item_Supplier_T.SupplierName, Invoice_T.Cost
FROM Shop_T, Item_Supplier_T, Invoice_T
WHERE (Invoice_T.ShopName = Shop_T.ShopName 
	AND Invoice_T.TaxNumber = Item_Supplier_T.TaxNumber)

SELECT Invoice_T.InvoiceNumber, Item_Supplier_T.SupplierName, Shop_T.ShopName,
	(SELECT SUM(Order_Line_T.ItemAmount * Order_Line_T.UnitPrice) 
		FROM Order_Line_T,Item_T 
		WHERE (Order_Line_T.ItemBarcode = Item_T.Barcode
		AND Invoice_T.InvoiceNumber = Order_Line_T.InvoiceNumber))
		AS Cost
FROM Item_Supplier_T, Invoice_T, Shop_T
WHERE (Invoice_T.TaxNumber = Item_Supplier_T.TaxNumber
	AND Invoice_T.ShopName = Shop_T.ShopName)
	

CREATE VIEW Citizen_Visitors_V
AS
SELECT c.CVisitorNumber, c.IDNumber, v.VisitorName, c.Province, v.Age
FROM Citizen_T c
INNER JOIN Visitor_T v on c.CVisitorNumber = v.VisitorNumber;

CREATE VIEW Shop_Employees_V
AS
SELECT e.PersonalID, e.EmployeeName, e.Salary, s.ShopName
FROM Employee_T e 
INNER JOIN Employees_in_Shop_T es
	ON e.PersonalID = es.PersonalID
	INNER JOIN Shop_T s
		ON es.ShopName = s.ShopName


CREATE VIEW Painting_Informations_V
AS
SELECT PieceNumber, PieceName, PieceDescription, YearOfMade, CountryOfOrigin
FROM Piece_T 
WHERE Piece_T.PieceNumber IN 
	(SELECT Painting_T.PPieceNumber
		FROM Painting_T)


CREATE PROCEDURE SelectAllVisitors @VisitorType VARCHAR(1), @VisitorGender VARCHAR(10)
AS
SELECT * FROM Visitor_T 
	WHERE VisitorType = @VisitorType AND Gender = @VisitorGender
GO

EXEC SelectAllVisitors @VisitorType = 'C', @VisitorGender = 'Female'


CREATE PROCEDURE SelectAllPieces @PieceType VARCHAR(1)
AS
SELECT * FROM Piece_T WHERE PieceType = @PieceType
GO

EXEC SelectAllPieces @PieceType = 'S'