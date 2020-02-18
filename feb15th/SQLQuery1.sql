create database productDB
use productDB;
create table Category(
Cid int primary key,
Cname varchar(max))

create table product(
Pid int primary key,
Cid int not null,
Title varchar(max),
price float not null 
 FOREIGN KEY (Cid) REFERENCES Category(Cid));