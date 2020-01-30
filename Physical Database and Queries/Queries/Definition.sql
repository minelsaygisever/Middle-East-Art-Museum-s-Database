USE MIDDLE_EAST_ART_MUSEUM

CREATE TABLE Employee_T 
	(PersonalID      INTEGER        NOT NULL,
	EmployeeName     VARCHAR(50)    NOT NULL,
	Task             VARCHAR(30)    NOT NULL,
	Salary           INTEGER        NOT NULL,
	EmployeeAddress  VARCHAR(75),
	Email            VARCHAR(30),
	ShopName         VARCHAR(40)    DEFAULT 'Not associated with any shop.',
	ManagerID        INTEGER,
	Birth            DATE,
	TicketNumber     INTEGER,
	PieceNumber      INTEGER,
	Age AS DATEDIFF(year, Birth, GETDATE())
CONSTRAINT Employee_PK PRIMARY KEY (PersonalID));

CREATE TABLE Employee_Phone_Number_T
	(PersonalID      INTEGER        NOT NULL    REFERENCES Employee_T,
	PhoneNumber      VARCHAR(11)    NOT NULL,
CONSTRAINT Employee_Phone_Number_PK PRIMARY KEY (PersonalID, PhoneNumber));


CREATE TABLE Employees_Language_T
	(PersonalID      INTEGER        NOT NULL    REFERENCES Employee_T,
	Languages        VARCHAR(20),
CONSTRAINT Employees_Language_PK PRIMARY KEY (PersonalID, Languages));

CREATE TABLE Shop_T 
	(ShopName        VARCHAR(40)    NOT NULL,
	Profit           INTEGER,
	ManagerID        INTEGER,
CONSTRAINT Shop_PK PRIMARY KEY (ShopName));


CREATE TABLE Shops_Items_T
	(ShopName        VARCHAR(40)    NOT NULL    REFERENCES Shop_T,
	Barcode          INTEGER        NOT NULL    REFERENCES Item_T,
CONSTRAINT Shops_Items_PK PRIMARY KEY (ShopName, Barcode));


CREATE TABLE Shop_Phone_Number_T
	(ShopName        VARCHAR(40)    NOT NULL    REFERENCES Shop_T,
	PhoneNumber      VARCHAR(11)    NOT NULL,
CONSTRAINT Shop_Phone_Number_PK PRIMARY KEY (ShopName, PhoneNumber));



CREATE TABLE Employees_in_Shop_T
	(ShopName        VARCHAR(40)    NOT NULL    REFERENCES Shop_T,
	PersonalID       INTEGER        NOT NULL    REFERENCES Employee_T,
CONSTRAINT Employees_in_Shop_PK PRIMARY KEY (ShopName, PersonalID));

CREATE TABLE Item_T
	(Barcode         INTEGER        NOT NULL,
	ItemName         VARCHAR(30)    NOT NULL,
	ItemDescription  VARCHAR(50),
	Price            REAL           NOT NULL,
	TaxPercentage    INTEGER        NOT NULL,
	ISTaxNumber      INTEGER,
CONSTRAINT Item_PK PRIMARY KEY (Barcode));

CREATE TABLE Book_T
	(BBarcode        INTEGER        NOT NULL    REFERENCES Item_T,
	Author           VARCHAR(50)    NOT NULL,
	Genre            VARCHAR(25)    NOT NULL,
CONSTRAINT Book_PK PRIMARY KEY (BBarcode));


CREATE TABLE Souvenir_T
	(SBarcode        INTEGER        NOT NULL    REFERENCES Item_T,
	Category         VARCHAR(30)
CONSTRAINT Souvenir_PK PRIMARY KEY (SBarcode));



CREATE TABLE Item_Supplier_T
	(TaxNumber         INTEGER        NOT NULL,
	SupplierName       VARCHAR(40)    NOT NULL,
	SupplierAddress    VARCHAR(75),
	Email              VARCHAR(30),
CONSTRAINT Item_Supplier_PK PRIMARY KEY (TaxNumber));



CREATE TABLE Item_Supplier_Phone_Number_T
	(ISTaxNumber     INTEGER        NOT NULL    REFERENCES Item_Supplier_T,
	PhoneNumber VARCHAR(15) NOT NULL,
CONSTRAINT Item_Supplier_Phone_Number_PK PRIMARY KEY (ISTaxNumber, PhoneNumber));



CREATE TABLE Visitor_T
	(VisitorNumber   INTEGER        NOT NULL,
	VisitorName      VARCHAR(50)    NOT NULL,
	PersonalID       INTEGER,        
	Age              INTEGER,
	Gender           VARCHAR(10),
	Email            VARCHAR(30),
	PhoneNumber      VARCHAR(15),
	VisitorType      VARCHAR(1)     NOT NULL,
CONSTRAINT Visitor_PK PRIMARY KEY (VisitorNumber),
CONSTRAINT Visitor_FK FOREIGN KEY (PersonalID) REFERENCES Employee_T(PersonalID));

CREATE TABLE Tourist_T
	(TVisitorNumber  INTEGER        NOT NULL    REFERENCES Visitor_T,
	PassportNumber   INTEGER        NOT NULL,
	Country          VARCHAR(25),
	VisitorTypeID AS 'T' PERSISTED,
CONSTRAINT Tourist_PK PRIMARY KEY (TVisitorNumber, PassportNumber));


CREATE TABLE Citizen_T
	(CVisitorNumber  INTEGER        NOT NULL    REFERENCES Visitor_T,
	IDNumber         VARCHAR(11)    NOT NULL,
	CitizenType      VARCHAR(1)     NOT NULL,
	Province VARCHAR(50),
	VisitorTypeID AS 'C' PERSISTED,
CONSTRAINT Citizen_PK PRIMARY KEY (CVisitorNumber, IDNumber));


CREATE TABLE Student_T
	(SCVisitorNumber INTEGER        NOT NULL,    
	SIDNumber        VARCHAR(11)    NOT NULL,
	CitizenTypeID AS 'S' PERSISTED,
	SchoolNumber     INTEGER,
	SchoolName       VARCHAR(50),
	Department       VARCHAR(50) DEFAULT 'No department');

--It has check constraint, added later
CREATE TABLE Adult_T
	(ACVisitorNumber	INTEGER		NOT NULL,
	AIDNumber			VARCHAR(11)	NOT NULL,
	CitizenTypeID AS 'A' PERSISTED,
	Job					VARCHAR(40),
	Company				VARCHAR(40) DEFAULT 'No company');

--This function used while checking adult's age
CREATE FUNCTION TakeAge (@ACVisitorNumber INTEGER)
RETURNS INTEGER AS
BEGIN
	RETURN
	(SELECT Visitor_T.Age
		FROM Visitor_T 
		WHERE Visitor_T.VisitorNumber = @ACVisitorNumber)
END

--Adding check constraint to Adult_T
ALTER TABLE Adult_T
ADD CHECK (dbo.TakeAge(Adult_T.ACVisitorNumber) >= 18)
   

CREATE TABLE Receipt_T
	(ShopName        VARCHAR(40)    NOT NULL    REFERENCES Shop_T,
	VisitorNumber    INTEGER        NOT NULL    REFERENCES Visitor_T,
	ReceiptNumber    INTEGER        NOT NULL,
	Cost             REAL           NOT NULL,
	CuttingDay       INTEGER        NOT NULL,
	CuttingMonth     INTEGER        NOT NULL,
	CuttingYear      INTEGER        NOT NULL,
	CuttingHour      INTEGER        NOT NULL,
	CuttingMinute    INTEGER        NOT NULL,
	Cashier          VARCHAR(15),
CONSTRAINT Receipt_PK PRIMARY KEY (ShopName, VisitorNumber, ReceiptNumber));


CREATE TABLE Ticket_T
	(PersonalID      INTEGER        NOT NULL    REFERENCES Employee_T,
	VisitorNumber    INTEGER        NOT NULL    REFERENCES Visitor_T,
	TicketNumber     INTEGER        NOT NULL,
	VisitorName      VARCHAR(50),
	Cost             INTEGER,
CONSTRAINT Ticket_PK PRIMARY KEY (PersonalID, VisitorNumber, TicketNumber));



CREATE TABLE Piece_T
	(PieceNumber     INTEGER        NOT NULL,
	PieceName        VARCHAR(50)    NOT NULL,
	PieceDescription VARCHAR(250),
	YearOfMade       INTEGER,
	EntryDay         INTEGER,
	EntryMonth       INTEGER,
	EntryYear        INTEGER,
	EntryHour        INTEGER,
	CountryOfOrigin  VARCHAR(25),
	PersonalID       INTEGER,
	PieceType        VARCHAR(1)     NOT NULL,
CONSTRAINT Piece_PK PRIMARY KEY (PieceNumber),
CONSTRAINT Piece_FK FOREIGN KEY (PersonalID) REFERENCES Employee_T (PersonalID));


CREATE TABLE Painting_T
	(PPieceNumber    INTEGER        NOT NULL    REFERENCES Piece_T,
	Painter          VARCHAR(50)    NOT NULL,
	Width            REAL,
	Height           REAL, 
	PaintType        VARCHAR(25),
	PieceTypeID AS 'P' PERSISTED,
CONSTRAINT Painting_PK PRIMARY KEY (PPieceNumber));



CREATE TABLE Sculpture_T
	(SPieceNumber    INTEGER        NOT NULL    REFERENCES Piece_T,
	Sculptor         VARCHAR(50)    NOT NULL,
	Width            REAL,
	Height           REAL, 
	Depth            REAL,
	Material         VARCHAR(25),
	PieceTypeID AS 'S' PERSISTED,
CONSTRAINT Sculpture_PK PRIMARY KEY (SPieceNumber));



CREATE TABLE Clothes_T
	(CPieceNumber    INTEGER        NOT NULL    REFERENCES Piece_T,
	Category         VARCHAR(50)    NOT NULL,
	ClothesOwner     VARCHAR(50),
	PieceTypeID AS 'C' PERSISTED,
CONSTRAINT Clothes_PK PRIMARY KEY (CPieceNumber));

CREATE TABLE Clothes_Materials_T
	(CPieceNumber    INTEGER        NOT NULL    REFERENCES Clothes_T,
	Material         VARCHAR(50)    NOT NULL,
CONSTRAINT Clothes_Materials_PK PRIMARY KEY (CPieceNumber, Material));


CREATE TABLE Tools_T
	(TPieceNumber    INTEGER        NOT NULL    REFERENCES Piece_T,
	Category         VARCHAR(50)    NOT NULL,
	ToolsOwner     VARCHAR(50),
	PieceTypeID AS 'T' PERSISTED,
CONSTRAINT Tools_PK PRIMARY KEY (TPieceNumber));

CREATE TABLE Tools_Materials_T
	(TPieceNumber    INTEGER        NOT NULL    REFERENCES Tools_T,
	Material         VARCHAR(50)    NOT NULL,
CONSTRAINT Tools_Materials_PK PRIMARY KEY (TPieceNumber, Material));

CREATE FUNCTION ComputeCost (@InvoiceNumber INTEGER)
RETURNS REAL AS
BEGIN
	RETURN
	(SELECT SUM(UnitPrice*ItemAmount)
		FROM Order_Line_T 
		WHERE Order_Line_T.InvoiceNumber = @InvoiceNumber)
END
   

CREATE TABLE Invoice_T
	(InvoiceNumber   INTEGER        NOT NULL,
	ShopName         VARCHAR(40)                REFERENCES Shop_T,
	TaxNumber        INTEGER        NOT NULL    REFERENCES Item_Supplier_T,
	CuttingDay       INTEGER        NOT NULL,
	CuttingMonth     INTEGER        NOT NULL,
	CuttingYear      INTEGER        NOT NULL,
	CuttingHour      INTEGER        NOT NULL,
	CuttingMinute    INTEGER        NOT NULL,
CONSTRAINT Invoice_PK PRIMARY KEY (InvoiceNumber, ShopName, TaxNumber));

ALTER TABLE Invoice_T
ADD Cost AS dbo.ComputeCost(InvoiceNumber)

CREATE TABLE Order_Line_T
	(ItemBarcode     INTEGER        NOT NULL,
	InvoiceNumber    INTEGER        NOT NULL,
	ShopName         VARCHAR(40)    NOT NULL,
	TaxNumber        INTEGER        NOT NULL,
	ItemAmount       INTEGER        NOT NULL,
	UnitPrice        REAL           NOT NULL);

ALTER TABLE Order_Line_T
ADD CONSTRAINT Order_Line_FK FOREIGN KEY (InvoiceNumber, ShopName, TaxNumber) REFERENCES Invoice_T (InvoiceNumber, ShopName, TaxNumber)
ALTER TABLE Order_Line_T
ADD CONSTRAINT Order_Line_PK PRIMARY KEY (ItemBarcode, InvoiceNumber, ShopNAme, TaxNumber)


ALTER TABLE Employee_T
ADD CONSTRAINT Employee_FK1 FOREIGN KEY (ShopName) REFERENCES Shop_T(ShopName),
	CONSTRAINT Employee_FK2 FOREIGN KEY (ManagerID) REFERENCES Employee_T (PersonalID),
	CONSTRAINT Employee_FK4 FOREIGN KEY (PieceNumber) REFERENCES Piece_T (PieceNumber);

ALTER TABLE Shop_T
ADD CONSTRAINT Shop_FK1 FOREIGN KEY (PersonalID) REFERENCES Employee_T (PersonalID),
	CONSTRAINT Shop_FK2 FOREIGN KEY (ManagerID) REFERENCES Employee_T (PersonalID);


ALTER TABLE Item_T
ADD CONSTRAINT Item_FK1 FOREIGN KEY (ISTaxNumber) REFERENCES Item_Supplier_T (TaxNumber),
	CONSTRAINT Item_FK2 FOREIGN KEY (ShopName) REFERENCES Shop_T (ShopName);

ALTER TABLE Student_T
ADD CONSTRAINT Student_FK FOREIGN KEY (SCVisitorNumber, SIDNumber) REFERENCES Citizen_T (CVisitorNumber, IDNumber);
ALTER TABLE Student_T
ADD	CONSTRAINT Student_PK PRIMARY KEY (SCVisitorNumber, SIDNumber);

ALTER TABLE Adult_T
ADD CONSTRAINT Adult_FK FOREIGN KEY (ACVisitorNumber, AIDNumber) REFERENCES Citizen_T (CVisitorNumber, IDNumber);
ALTER TABLE Adult_T
ADD CONSTRAINT Adult_PK PRIMARY KEY (ACVisitorNumber, AIDNumber);

CREATE UNIQUE INDEX Item
ON Shops_Items_T(ShopName, Barcode);	

ALTER TABLE Employee_T
ADD UNIQUE (PersonalID);

ALTER TABLE Piece_T
ADD UNIQUE (PieceNumber);

ALTER TABLE Item_T
ADD UNIQUE(Barcode);

ALTER TABLE Receipt_T
ADD UNIQUE (ReceiptNumber);

ALTER TABLE Shop_T
ADD UNIQUE (ShopName);

ALTER TABLE Ticket_T
ADD UNIQUE (TicketNumber);

ALTER TABLE Visitor_T
ADD UNIQUE (VisitorNumber);
