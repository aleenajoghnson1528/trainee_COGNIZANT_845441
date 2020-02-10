use student
go;
create trigger Studenttrigger on  studentnew
after insert
as

print 'one row is inserted...after insert triger';

go;
create trigger studenttriger on  studentnew
for insert
as

print 'do u want to insert..after insert triger';

go;

select * from studentnew
insert into studentnew(Student_id,Name,address1,age) values(133,'akshai','uvxz',5);
insert into studentnew(Student_id,Name,address1,age) values(144,'anna','vgs',3);
insert into studentnew(Student_id,Name,address1,age) values(145,'anna','vgs',3);