


CREATE TABLE EmployeeTable (
	employeeID int NOT NULL PRIMARY KEY,
    FIRSTNAME VARCHAR(255),
	LASTNAME VARCHAR(255),
	EMAIL VARCHAR(255),
	CITY VARCHAR(255),
	SALARY int, DESIGNATION VARCHAR(255),
	CREATEDDATE date, MODIFIEDDATE date, ISACTIVE bit);

CREATE TABLE GroupTable
(
    GroupID int NOT NULL PRIMARY KEY,
    Name varchar(255),
    Description varchar(255) Default null,
    CreatedDate date,
    ModifiedDate date,
    IsActive bit
);
 

CREATE TABLE EmployeeGroupTable
(
    EmployeeGroupTableID int NOT NULL PRIMARY KEY,
    GroupId int,
    employeeID int,
    ModifiedDate date,
    IsActive bit,
    FOREIGN KEY(GroupId) REFERENCES GroupTable( GroupID ),
    FOREIGN KEY(employeeID) REFERENCES EmployeeTable(employeeID)
);