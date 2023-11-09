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

create table GroupTable
(
ID  int  not null primary key, 
Names  varchar(255), 
Descriptions varchar(1024) null, 
CreatedDate datetime,   
ModifiedDate  datetime, 
IsActive   bit, 
);

create table UserGroupTable
(
ID   int not null primary key , 
GroupId   int,  
UserId   int,  
FOREIGN KEY (UserId) REFERENCES UserDetails(ID), 
FOREIGN KEY (GroupId) REFERENCES GroupTable(ID), 
ModifiedDate   datetime, 
IsActive   bit, 
);


insert into UserDetails values(1,'Karthi','keyan','karthi@gmail.com','chennai',21500,'developer','2022-12-02 10:11','2023-09-10 01:45',1);
insert into UserDetails values(2,'Surya','sekar','surya@gmail.com','madurai',31500,'developer','2021-12-02 10:11','2022-09-10 01:45',1);
insert into UserDetails values(3,'Murugan','Siva','murugan@gmail.com','coimbatore',41500,'developer','2020-12-02 10:11','2022-09-10 01:45',1);
insert into UserDetails values(4,'Madhan','Goapl','madhan@gmail.com','sivakasi',21500,'developer','2022-03-02 10:11','2023-07-10 01:45',1);
insert into UserDetails values(5,'Chandru','sekar','chandru@gmail.com','chengalpattu',21500,'developer','2022-05-02 10:11','2022-09-10 01:45',1);
insert into UserDetails values(6,'Vishnu','vishal','vishnu@gmail.com','chennai',51500,'developer','2019-12-02 10:11','2022-10-10 01:45',1);
insert into UserDetails values(7,'Janani','priya','janani@gmail.com','vellore',61500,'developer','2018-01-02 10:11','2020-09-10 01:45',1);
insert into UserDetails values(10,'Janavi','priya','janavi@gmail.com','vellore',61500,'developer','2018-01-02 10:11','2020-09-10 01:45',1);
insert into UserDetails values(8,'Arun','n','arun@gmail.com','chennai',21500,'developer','2022-12-02 10:11','2023-09-10 01:45',1);
insert into UserDetails values(9,'ajay','k','karthi@gmail.com','chennai',21500,'developer','2022-12-02 10:11','2023-09-10 01:45',1);
insert into UserDetails values(11,'priya','mani','priya@gmail.com','vellore',61500,'developer','2018-01-02 10:11','2020-09-10 01:45',1);

insert into GroupTable values(1,'Bold bi','It is the best product','2023-04-02','2023-10-10',1);
insert into GroupTable values(2,'Bold desk','It is the best product','2023-03-02','2023-10-10',1);
insert into GroupTable values(3,'Bold sign','It is the best product','2023-02-02','2023-05-10',1);
insert into GroupTable values(4,'Bold view','It is the best product','2023-01-02','2023-07-10',1);
insert into GroupTable values(5,'PDF','It is the best product','2023-07-02','2023-08-10',1);
insert into GroupTable values(6,'Bold game','It is the best product','2023-06-02','2023-09-10',1);
insert into GroupTable values(7,'Bold EXCEL','It is the best product','2023-06-02','2023-09-10',1);
insert into GroupTable(ID,Names,CreatedDate,ModifiedDate,IsActive) values(8,'power bi','2023-04-02','2023-10-10',1);
insert into GroupTable(ID,Names,CreatedDate,ModifiedDate,IsActive) values(9,'palin desk','2023-03-02','2023-10-10',1);
insert into GroupTable(ID,Names,CreatedDate,ModifiedDate,IsActive) values(10,'Automation','2023-04-02','2023-10-10',1);
insert into GroupTable(ID,Descriptions,CreatedDate,ModifiedDate,IsActive) values(11,'It is the best product','2023-06-02','2023-09-10',1);


insert into UserGroupTable values(1,6,1,'2023-12-02',1);
insert into UserGroupTable values(2,3,2,'2023-12-02',1);
insert into UserGroupTable values(3,1,5,'2023-12-02',1);
insert into UserGroupTable values(4,4,7,'2023-12-02',1);
insert into UserGroupTable values(5,2,3,'2023-12-02',1);
insert into UserGroupTable values(6,2,4,'2023-12-02',1);
insert into UserGroupTable values(7,9,8,'2023-12-02',1);
insert into UserGroupTable values(8,8,9,'2023-12-02',1);
insert into UserGroupTable values(10,10,10,'2023-12-02',1);
insert into UserGroupTable values(11,11,11,'2023-12-02',1);





Select * from GroupTable
Select * from UserDetails
Select * from UserGroupTable



select userDetails.FirstName, Grouptable.Id,grouptable.Names from  UserDetails  join UserGroupTable on   UserDetails.ID =UserGroupTable.UserId 
right outer join GroupTable on GroupTable.ID=UserGroupTable.GroupId;

select userDetails.FirstName, Grouptable.Id,grouptable.Names from  UserDetails  join UserGroupTable on   UserDetails.ID =UserGroupTable.UserId 
join GroupTable on GroupTable.ID=UserGroupTable.GroupId where GroupTable.CreatedDate>'2023-03-02' and GroupTable.Names is not null;