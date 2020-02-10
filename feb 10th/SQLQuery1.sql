use EmployeeDB
go;
create trigger Employeetriger on  Employeenew
after insert
as

print 'one row is inserted...after insert triger';

go;
select * from Employeenew
insert into Employeenew(Eid,Ename,Designation,Basic_salary) values(11,'akshai','java developer',45000);