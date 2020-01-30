USE MIDDLE_EAST_ART_MUSEUM

--A few examples of insert into
INSERT INTO Employee_T (PersonalID, EmployeeName, Task, Salary, EmployeeAddress, Email, Birth_Day, Birth_Month, Birth_Year, ShopName, ManagerID)
	VALUES (1001, 'Melda Yýldýz', 'Manager', 7500, 'Keçiören', 'melda.yildiz@meam.com', 7, 1, 1975, NULL, NULL);

INSERT INTO Employee_T (PersonalID, EmployeeName, Task, Salary, EmployeeAddress, Email, Birth_Day, Birth_Month, Birth_Year, ShopName, ManagerID)	
	VALUES (1010, 'Beril Çalýþkan', 'Information Desk', 4000, 'Sincan', 'beril.caliskan@meam.com', 28, 2, 1990, NULL, 1001);

INSERT INTO Employee_T (PersonalID, EmployeeName, Task, Salary, EmployeeAddress, Email, Birth_Day, Birth_Month, Birth_Year, ShopName, ManagerID)	
	VALUES (1020, 'Aykut Rahat', 'Security Guard', 2020, 'Polatlý', 'aykut.rahat@meam.com', 15, 7, 1986, NULL, 1001);

INSERT INTO Piece_T (PieceNumber, PieceName, PieceDescription, YearOfMade, EntryDay, EntryMonth, EntryYear, EntryHour, CountryOfOrigin, PersonalID, PieceType)
	VALUES (100, 'Fury of the Ocean', 'The painter tried to convey the anger he accumulated against humanity in the language of the oceans to us.', 2001, 15, 8, 2017, 14, 'India', 1033, 'P');

INSERT INTO Piece_T (PieceNumber, PieceName, PieceDescription, YearOfMade, EntryDay, EntryMonth, EntryYear, EntryHour, CountryOfOrigin, PersonalID, PieceType)
	VALUES (101, 'Bird Man', 'Our sculptor, who lives in the peaks of feminism, thinks that all men are bird brains and as a result makes this statue.', 2011, 2, 4, 2017, 10, 'Yemen', 1032, 'S');

INSERT INTO Piece_T (PieceNumber, PieceName, PieceDescription, YearOfMade, EntryDay, EntryMonth, EntryYear, EntryHour, CountryOfOrigin, PersonalID, PieceType)
	VALUES (102, 'There Is Hair Everywhere', 'Protesting the obligation of women to cover their hair, our artist has cut her hair since she was 15 and created this dress at the age of 32 with this hair.', 2018, 6, 10, 2019, 11, 'Saudi Arabia', 1031, 'C');

INSERT INTO Piece_T (PieceNumber, PieceName, PieceDescription, YearOfMade, EntryDay, EntryMonth, EntryYear, EntryHour, CountryOfOrigin, PersonalID, PieceType)
	VALUES (103, 'Silence of Goats', 'The inadequacy of financial means caused our painter to make a brush set from his goats'' hair.', 2010, 21, 7, 2018, 12, 'Palestine', 1030, 'T');

INSERT INTO Visitor_T (VisitorNumber, VisitorName, Age, Gender, Email, PhoneNumber, VisitorAddress)
	VALUES (8000, 'Yaren Ok', 21, 'Female', 'yaren.ok@visitor.com', '05426663325', 'Ankara');



BEGIN TRANSACTION
	INSERT INTO Item_T(Barcode, ItemName, ItemDescription, Price, TaxPercentage, ISTaxNumber)	
	VALUES (236522, 'Jasmine Cologne', '200 ml jasmine scented cologne', 40, 18, 12115422)
	
	UPDATE Item_T
	SET Price = 'Wrong value type'
	WHERE Barcode=215246