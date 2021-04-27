IF EXISTS (SELECT * FROM sys.sysdatabases WHERE name = 'Inventory') DROP DATABASE Inventory;

CREATE DATABASE Inventory ;

SET DATEFORMAT dmy;
GO

use Inventory;

DROP TABLE IF EXISTS Inventory.dbo.Companies;

CREATE TABLE Inventory.dbo.Companies
(
    companyID int NOT NULL IDENTITY(1, 1), CONSTRAINT Inventory_companies_company_id PRIMARY KEY CLUSTERED (companyID),
    companyName varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NOT NULL,
	NIP int NOT NULL CONSTRAINT Inventory_companies_NIP UNIQUE (NIP),
	streetName varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NULL,
	buildingNo varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NULL,
	postalCode varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NULL,
    city varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NULL
);

DROP TABLE IF EXISTS Inventory.dbo.Employees;

CREATE TABLE Inventory.dbo.Employees
(
    employeeID int NOT NULL IDENTITY(1, 1), CONSTRAINT Inventory_employees_employee_id PRIMARY KEY CLUSTERED (employeeID),
	companyID int NOT NULL, CONSTRAINT Inventory_employees_company_id FOREIGN KEY (companyID) REFERENCES Inventory.dbo.Companies (companyID),
	employeeName varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NOT NULL,
	employeeSurname varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NOT NULL,
	position varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NULL,
	phone varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NULL,
    email varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NULL
);

DROP TABLE IF EXISTS Inventory.dbo.Computers;

CREATE TABLE Inventory.dbo.Computers
(
	computerID int NOT NULL IDENTITY(1, 1), CONSTRAINT Inventory_computers_computer_id PRIMARY KEY CLUSTERED (computerID),
	companyID int NOT NULL, CONSTRAINT Inventory_computers_company_id FOREIGN KEY (companyID) REFERENCES Inventory.dbo.Companies (companyID) ON DELETE CASCADE,
	employeeID int NULL, CONSTRAINT Inventory_computers_employee_id FOREIGN KEY (employeeID) REFERENCES Inventory.dbo.Employees (employeeID) ON DELETE SET NULL,
	dateOfPurchase date NULL DEFAULT GETDATE(),
	CPU varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NULL,
	RAMSize int NULL,
	DiskSize int NULL,
	windowsKey varchar(255) COLLATE LATIN1_GENERAL_100_CI_AS_SC_UTF8 NULL,
);
GO

-- INSERT SAMPLE DATA --
INSERT INTO Inventory.dbo.Companies (companyName, NIP, streetName, buildingNo, postalCode, city) VALUES
    ('Strat Security', 542123456, 'Zwyciêstwa', '102', '60-475', 'Poznañ'),
    ('Vortex Solar', 502109123, 'Morska', '12A', '80-873', 'Gdañsk'),
    ('Lambent Illumination', 543321456, 'Koszykowa', '75', '00-662', 'Warszawa');

INSERT INTO Inventory.dbo.Employees (companyID, employeeName, employeeSurname, position, phone, email) VALUES
    (1, 'Anna', 'Nowak', 'Ksiêgowa', '+4812345689', 'anna.nowak@wp.pl'),
    (1, 'Szymon', 'Kowalski', 'Zastêpca dyrektora', '+48987654321', 'szymon.kowalski@gmail.com'),
	(1, 'Bart³omiej', 'Kot', 'Dyrektor', '+48201340120', 'bartlomiej.kot@stratsecurity.com'),
    (2, 'Zdzis³aw', 'Bratek', 'Administrator sieci', '+48147457897', 'zbratek@onet.pl'),
    (2, 'Micha³', 'Antosik', 'Elektryk', '+48154687364', 'michalantosik@wp.pl'),
	(2, 'Tymoteusz', 'Baczewski', 'Dyrektor ds. rozwoju', '+48955457124', 't.baczewski@vortex.com.pl'),
	(3, 'Adam', 'Szczeciñski', 'Zastêpca ksiêgowego', '+48456745782', 'aszczecinski@lambent.waw.pl'),
    (3, 'Pawe³', 'Muzyka', 'Konserwator', '+48456789143', 'pawel.muzyka352@gmail.com'),
	(3, 'Wojciech', 'Banaszek', 'Inspektor RODO', '+48235645789', 'wojciech.banaszek@outlook.com');


INSERT INTO Inventory.dbo.Computers (companyID, employeeID, DiskSize) VALUES
	(1, 1, 100),
	(1, 1, 200),
	(1, 2, 300),
	(1, 3, 400),
	(2, 1, 500),
	(2, 2, 600),
	(2, 2, 700),
	(2, 2, 800),
	(2, 3, 900),
	(3, 1, 1000),
	(3, 2, 1100),
	(3, 3, 1200);