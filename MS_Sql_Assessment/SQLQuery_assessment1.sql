create database sample6
alter database sample6 modify name=  Assessment
sp_renameDB 'Assessment', 'Assessmentno1'
drop database Assessmentno1