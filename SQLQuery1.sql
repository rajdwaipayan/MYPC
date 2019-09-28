CREATE DATABASE CoffeeShop
USE CoffeeShop

CREATE TABLE Items(
ID INT IDENTITY(1,1),
name VARCHAR(50),
price INT

)

INSERT INTO Items(name,price)VALUES('Dwaipo',12)
SELECT * FROM Items

DROP TABLE Items


CREATE TABLE Orders(
ID INT IDENTITY(1,1),
Name VARCHAR(50),
Item VARCHAR(10),
Address VARCHAR(40),
Contact VARCHAR(20),
Price INT,
Quantity INT,
Total_Price INT 
)
DELETE FROM Orders
 DROP TABLE Orders
SELECT * FROM Orders


CREATE TABLE Customers(
ID INT IDENTITY(1,1),
Name VARCHAR(50),
Address VARCHAR(20),
Contact VARCHAR(20)
)

DROP TABLE Customers
INSERT INTO Customers(Name,Address,Contact) VALUES ('DWAIPO','DHAKA',125)
SELECT * FROM Customers
DELETE FROM Customers