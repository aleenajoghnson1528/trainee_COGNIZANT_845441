create database Employeenewdb
use Employeenewdb
create table employee(EmpID INT NOT NULL,
	EmpName VARCHAR (50) NOT NULL,
	SSN BIGINT NOT NULL,
	Salary FLOAT NOT NULL,
	DepID INT NOT NULL);
	INSERT INTO Employee VALUES (1,'BINCY',23456,40000.00,1);
INSERT INTO Employee VALUES (2, 'ARYA',23457,40000.00,2);
INSERT INTO Employee VALUES (3, 'AFSANA',23458,40000.00,3);
INSERT INTO Employee VALUES (4, 'TINCY',23459,40000.00,4);
INSERT INTO Employee VALUES (5, 'MRIDHU',23460,40000.00,5);
SELECT * FROM Employee;
create table Department
(DepID int PRIMARY KEY not null,
DepName varchar(30) not null);

insert into Department values(1,'Admin');
insert into Department values(2,'Marketing');
insert into Department values(3,'Technical');
insert into Department values(4,'Stores');
select * from Department;
SELECT * FROM Employee;
alter table Employee add Constraint fK_DepID1 FOREIGN KEY (DepID) REFERENCES Department(DepID);
go;
create trigger Employeetrigernew on  Employee
after insert
as

print 'one row is inserted...after insert triger';

go;
INSERT INTO Employee VALUES (6, 'johnson',56784,40000.00,2);
go;
create trigger Employeetriger11 on  Employee
after update
as

print 'one row is updated...after insert triger';
go;
update  employee set salary=45000 where EmpID=6;
select * from employee
go;
create trigger Employeetrigernew11 on  Employee
after delete
as

print 'one row is deleted..after delete triger';
go;
delete from employee where EmpID=6