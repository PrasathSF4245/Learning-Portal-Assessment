create database DetailsTable
use [DetailsTable]
go
create table UserDetails(
ID  int NOT NULL Primary key identity, 
FirstName  varchar(255) , 
LastName  varchar(255) , 
Email  varchar(255) , 
City varchar(255) , 
Salary  numeric , 
Designation  varchar(255) , 
CreatedDate  datetime , 
ModifiedDate  datetime , 
IsActive  bit 
);
create table UserGroup1
(
ID  int  not null primary key identity, 
Names  varchar(255), 
Descriptions varchar(1024), 
CreatedDate datetime,   
ModifiedDate  datetime, 
IsActive   bit, 
);

create table UserGroup2
(
ID   int not null primary key identity, 
GroupId   int,  
UserId   int,  
FOREIGN KEY (UserId) REFERENCES UserDetails(ID), 
FOREIGN KEY (GroupId) REFERENCES UserGroup1(ID), 
ModifiedDate   datetime, 
IsActive   bit, 
);

INSERT INTO UserDetails VALUES(  'Rajesh',  'K', 'Rajeshraj@gmail.com', 'chennai', 20000, 'Tester', CAST(N'2023-03-11 7:31:09.000' AS DateTime), CAST(N'2023-04-16 11:20:08.000' AS DateTime), 0),
(  'sunil',  'M', 'sunil@gmail.com', 'Salem', 80000, 'Developer', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1),
(  'kannan',  'T', 'kannan@gmail.com', 'Chennai', 100000, 'Engineer', CAST(N'2023-02-11 2:30:09.000' AS DateTime), CAST(N'2023-03-10 9:12:07.000' AS DateTime), 1),
  ('Arun',  'K', 'arun@gmail.com', 'chennai', 20000, 'Tester', CAST(N'2023-03-11 7:31:09.000' AS DateTime), CAST(N'2023-04-16 11:20:08.000' AS DateTime), 0),
(  'Aravind',  'K', 'aravind@gmail.com', 'chennai', 20000, 'Tester', CAST(N'2023-03-11 7:31:09.000' AS DateTime), CAST(N'2023-04-16 11:20:08.000' AS DateTime), 0);

INSERT INTO UserGroup1 VALUES(  'Rajesh','He is a good tester and identifies bug easily', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 0) ,
(  'sunil', 'Developer with good creative skills', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1),
(  'kannan', 'Creative Engineer', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1),
(  'Arun', 'Developer with good creative skills', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1),
(  'Aravind', 'Developer with good creative skills', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1);

INSERT INTO UserGroup2 VALUES( '1', '1', CAST(N'2023-02-10 9:12:07.000' AS DateTime), 0) ,
( '2', '2', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1),
( '3', '3', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1),
( '4', '4', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1),
( '5', '5', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1);

----drop database DetailsTable