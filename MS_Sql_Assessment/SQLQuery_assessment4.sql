create database DetailsTable
use [DetailsTable]
go
create table UserDetails(
ID  int NOT NULL Primary key, 
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
ID  int  not null primary key, 
Names  varchar(255), 
Descriptions varchar(1024), 
CreatedDate datetime,   
ModifiedDate  datetime, 
IsActive   bit, 
);

create table UserGroup2
(
ID   int not null primary key , 
GroupId   int,  
UserId   int,  
FOREIGN KEY (UserId) REFERENCES UserDetails(ID), 
FOREIGN KEY (GroupId) REFERENCES UserGroup1(ID), 
ModifiedDate   datetime, 
IsActive   bit, 
);

INSERT INTO UserDetails VALUES('1',  'Rajesh',  'K', 'Rajeshraj@gmail.com', 'chennai', 20000, 'Tester', CAST(N'2023-03-11 7:31:09.000' AS DateTime), CAST(N'2023-04-16 11:20:08.000' AS DateTime), 0),
('2',  'sunil',  'M', 'sunil@gmail.com', 'Salem', 80000, 'Developer', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1),
('3',  'kannan',  'T', 'kannan@gmail.com', 'Chennai', 100000, 'Engineer', CAST(N'2023-02-11 2:30:09.000' AS DateTime), CAST(N'2023-03-10 9:12:07.000' AS DateTime), 1);

INSERT INTO UserGroup1 VALUES('1',  'PowerBI','He is a good tester and identifies bug easily', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 0) ,
('2',  'BoldBI', 'Developer with good creative skills', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1),
('3',  'WPF', 'Creative Engineer', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1);

INSERT INTO UserGroup2 VALUES('1', '1', '1', CAST(N'2023-02-10 9:12:07.000' AS DateTime), 0) ,
('2', '2', '2', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1),
('3', '3', '3', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1);
alter table UserGroup1
add constraint DF_UserGroup1_description
Default 'No description' for Descriptions;
 
 INSERT INTO UserGroup1 ( Names, CreatedDate ,   
ModifiedDate  , 
IsActive    ) VALUES('Ravi', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 0);

select * from UserDetails;
select * from UserGroup1;
select * from UserGroup2;