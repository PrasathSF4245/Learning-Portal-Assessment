create database Assessmenttables
use [Assessmenttables]
go
create table employee_details
(
ID  int not null primary key identity,
FirstName  varchar(255),
LastName  varchar(255),
Email  varchar(255),
City  varchar(255),
Salary  int,
Designation  varchar(255),
CreatedDate  datetime,
ModifiedDate  datetime,
IsActive  bit
)

INSERT INTO employee_details 
Values ('arun','v','av@gmail.com','guindy',5000,'jn.developer',CAST(N'2023-06-18 10:34:09.000' AS DateTime),CAST(N'2023-06-18 10:34:09.000' AS DateTime),1),
 ('karthick','K','k@gmail.com','Chetpet',80000,'sr.developer',CAST(N'2023-07-15 10:34:09.000' AS DateTime),CAST(N'2023-06-18 10:34:09.000' AS DateTime),1),
 ('saravanan','n','ns@gmail.com','chennai',90000,'sr.developer',CAST(N'2023-08-14 10:34:09.000' AS DateTime),CAST(N'2023-06-18 10:34:09.000' AS DateTime),1),
 ('Vignesh','s','vs@gmail.com','guindy',90000,'sr.developer',CAST(N'2023-08-13 10:34:09.000' AS DateTime),CAST(N'2023-06-18 10:34:09.000' AS DateTime),1),
 ('vidya','s','vis@gmail.com','guindy',80000,'developer',CAST(N'2023-06-19 10:34:09.000' AS DateTime),CAST(N'2023-06-18 10:34:09.000' AS DateTime),1),
 ('swetha','p','sp@gmail.com','Chetpet',50000,'developer',CAST(N'2023-06-11 10:34:09.000' AS DateTime),CAST(N'2023-06-18 10:34:09.000' AS DateTime),1),
 ('srini','n','sn@gmail.com','chennai',500000,'developer',CAST(N'2023-06-16 10:34:09.000' AS DateTime),CAST(N'2023-06-18 10:34:09.000' AS DateTime),1),
 ('vishwa','k','kv@gmail.com','chennai',5000,'developer',CAST(N'2023-06-18 10:34:09.000' AS DateTime),CAST(N'2023-06-18 10:34:09.000' AS DateTime),1);

select sum(Salary) from employee_details group by Designation 

select sum(Salary) from employee_details group by City , Designation