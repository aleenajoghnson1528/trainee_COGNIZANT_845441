use student;
create table department(
Did nchar(5) primary key,
Dname varchar(500) not null
)
create table employee(
Eid nchar(5) primary key,
Ename varchar(max) not null,
Designation varchar(200),
Did nchar(5) foreign key references department(Did)
)


insert into department values('101','production');
insert into department values('102','hr');
insert into department values('103','logistics');
select * from department;
insert into employee values('1','aleena','programmer','101');
insert into employee values('2','anand','executive','102');
insert into employee values('3','adarsh','marketting','103');
insert into employee values('4','lovely','operator','103');
insert into employee values('5','johnson','analyst','102');
select * from employee;

select * from employee where eid=1