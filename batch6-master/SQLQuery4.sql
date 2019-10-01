CREATE TABLE Items(
ID INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50),
Price FLOAT
)
DROP TABLE Items
INSERT INTO Items (Name, Price) Values ('Black', 120)
INSERT INTO Items (Name, Price) Values ('Regular', 80)
INSERT INTO Items (Name, Price) Values ('Cold', 100)
INSERT INTO Items (Name, Price) Values ('Hot', 90)

CREATE TABLE Customers
(
Id INT IDENTITY(1,1),
Name VARCHAR(50),
[Address] VARCHAR(200),
Contact VARCHAR(50),
)
DROP TABLE Customers
INSERT INTO Customers VALUES ('Ali', 'Dhaka' ,'01311369369')
INSERT INTO Customers VALUES ('Hasan', 'Sylhet' ,'01711369369')
INSERT INTO Customers VALUES ('Rafi', 'BNorisal' ,'01811369369')

SELECT * FROM Items
SELECT * FROM Customers

CREATE TABLE Orders
(
Id INT IDENTITY(1,1),
CustomerId INT,
ItemId INT,
Quantity INT,
TotalPrice FLOAT
)

INSERT INTO Orders(CustomerId,ItemId,Quantity,TotalPrice) VALUES(3,5,6,600)


SELECT o.Id,CustomerId,ItemId,Quantity,TotalPrice From Orders AS o
LEFT JOIN Customers as c ON c.Id=o.CustomerId

LEFT JOIN Items as i ON i.Id=o.ItemId

DROP TABLE Orders

