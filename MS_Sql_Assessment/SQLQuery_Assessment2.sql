create database Assessmenttables
use [Assessmenttables]
go
create table userdetails(
ID  int NOT NULL primary key,
FirstName  varchar(255) NOT NULL,
LastName  varchar(255) NOT NULL,
Email  varchar(255) NOT NULL,
City varchar(255) NOT NULL,
Salary  numeric NOT NULL,
Designation  varchar(255) NOT NULL,
CreatedDate  datetime NOT NULL,
ModifiedDate  datetime NOT NULL,
IsActive  bit NOT NULL
);
create table Groupofuser
(
ID  int  not null primary key,
Names  varchar(255),
Descriptions  varchar(1024),
CreatedDate   datetime,  
ModifiedDate   datetime,
IsActive   bit,
);

create table UserGroup
(
ID   int not null primary key ,
GroupId   int, 
 FOREIGN KEY (GroupId) REFERENCES Groupofuser(ID),
UserId   int, 
FOREIGN KEY (UserId) REFERENCES userdetails(ID),
ModifiedDate   datetime,
IsActive   bit,
);
