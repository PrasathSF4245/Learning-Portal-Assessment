


CREATE TABLE EmployeeTable (
	employeeID int NOT NULL PRIMARY KEY,
    FIRSTNAME VARCHAR(255),
	LASTNAME VARCHAR(255),
	EMAIL VARCHAR(255),
	CITY VARCHAR(255),
	SALARY int, DESIGNATION VARCHAR(255),
	CREATEDDATE date,
	MODIFIEDDATE date,
	ISACTIVE bit);

CREATE TABLE GroupTable
(
    GroupID int NOT NULL PRIMARY KEY,
    Name varchar(255),
    Description varchar(255) ,
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



insert into EmployeeTable values(1,'Karthi','keyan','karthi@gmail.com','chennai',21500,'developer','2022-12-02 10:11','2023-09-10 01:45','1');
insert into EmployeeTable values(2,'Surya','sekar','surya@gmail.com','madurai',31500,'tester','2021-12-02 10:11','2022-09-10 01:45','0');
insert into EmployeeTable values(3,'Murugan','Siva','murugan@gmail.com','coimbatore',41500,'support','2020-12-02 10:11','2022-09-10 01:45','1');
insert into EmployeeTable values(4,'Madhan','Goapl','madhan@gmail.com','sivakasi',21500,'developer','2022-03-02 10:11','2023-07-10 01:45','1');
insert into EmployeeTable values(5,'Chandru','sekar','chandru@gmail.com','chengalpattu',21500,'tester','2022-05-02 10:11','2022-09-10 01:45','1');
insert into EmployeeTable values(6,'Vishnu','vishal','vishnu@gmail.com','chennai',51500,'support','2019-12-02 10:11','2022-10-10 01:45','0');

insert into GroupTable values(1,'Bold bi','It is the best product','2023-04-02','2023-10-10','1');
insert into GroupTable values(2,'Bold desk','It is the best product','2023-03-02','2023-10-10','1');
insert into GroupTable values(3,'Bold sign','It is the best product','2023-02-02','2023-05-10','1');
insert into GroupTable values(4,'Bold view','It is the best product','2023-01-02','2023-07-10','1');
insert into GroupTable values(5,'PDF','It is the best product','2023-07-02','2023-08-10','1');
insert into GroupTable values(6,'Bold game','It is the best product','2023-06-02','2023-09-10','1');
insert into GroupTable values(7,'Bold EXCEL','It is the best product','2023-06-02','2023-09-10','1');

insert into GroupTable (GroupID,Name,CreatedDate,ModifiedDate,IsActive) values(8,'Power BI','2023-06-02','2023-09-10','1');

insert into EmployeeGroupTable values(1,6,1,'2023-12-02','1');
insert into EmployeeGroupTable values(2,3,2,'2023-12-02','1');
insert into EmployeeGroupTable values(3,1,5,'2023-12-02','1');
insert into EmployeeGroupTable values(4,4,6,'2023-12-02','1');
insert into EmployeeGroupTable values(5,2,3,'2023-12-02','1');


insert into EmployeeTable values(8,'Arun','n','arun@gmail.com','chennai',21500,'developer','2022-12-02 10:11','2023-09-10 01:45','1');
insert into EmployeeTable values(9,'Ajay','k','ajaykarthi@gmail.com','chennai',21500,'developer','2022-12-02 10:11','2023-09-10 01:45','1');


insert into GroupTable(GroupID,Name,CreatedDate,ModifiedDate,IsActive) values(10,'gold bi','2023-04-02','2023-10-10','1');
insert into GroupTable(GroupID,Name,CreatedDate,ModifiedDate,IsActive) values(9,'palin desk','2023-03-02','2023-10-10','1');


select * from EmployeeTable where FirstName like 'A%' order by createddate desc;

select firstname, email from EmployeeTable where ModifiedDate>'2020-12-02';

select * from GroupTable where description is null order by Name;