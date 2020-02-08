use EmployeeDB
create table Employeenew(
Eid int primary key,
Ename Varchar(max) not null,
Designation varchar(max),
Basic_salary money );
go;

create procedure enterdata
@Eid int,
 @Ename varchar(max),
  @Designation varchar(max), 
  @Basic_salary money


as
set nocount on
    
        BEGIN  
            INSERT INTO Employeenew  (Eid ,
							       Ename ,
									Designation ,
									Basic_salary )
                       
            VALUES     ( @Eid,
                         @Ename,
                         @Designation ,
                         @Basic_salary )
                          
 end;
 go;
 select * from Employeenew

 exec Enterdata @Eid=1, @Ename="Aleena", @Designation="developer", @Basic_salary=35000
 exec Enterdata @Eid=2, @Ename="Anand", @Designation="tester", @Basic_salary=30000
 exec Enterdata @Eid=3, @Ename="Adarsh", @Designation="web designer", @Basic_salary=35000
 exec Enterdata @Eid=4, @Ename="Lovely", @Designation="networking", @Basic_salary=40000
 exec Enterdata @Eid=5, @Ename="johnson", @Designation="developer", @Basic_salary=35000

 exec Enterdata @Eid=6, @Ename="Afsana", @Designation="data analyst", @Basic_salary=35000
 exec Enterdata @Eid=7, @Ename="divya", @Designation="developer", @Basic_salary=35000
 exec Enterdata @Eid=8, @Ename="Aiswarya", @Designation="c# coder", @Basic_salary=40000
 exec Enterdata @Eid=9, @Ename="tincy", @Designation="cloud analyst", @Basic_salary=45000
 exec Enterdata @Eid=10, @Ename="mridula", @Designation="tester", @Basic_salary=35000

 go;

 create Function Getsalarynew111()

returns money
as
begin
Declare @tfee money;

select @tfee=sum(Basic_salary*1.2*1.1*.97*.97) from Employeenew where Eid=1;
return @tfee;

End;
go;

select dbo.Getsalarynew111() as Totalsalary;
go;

CREATE FUNCTION NETSALARY(@SALARY MONEY)
RETURNS MONEY
AS
BEGIN
RETURN(@SALARY*1.2*1*.97*.97)

END;
GO;
SELECT Ename,dbo. NETSALARY(Basic_salary) as tosalary from Employeenew;
go;


create function GetIncentive1(@id int, @incentive money)
RETURNS MONEY
AS
BEGIN
declare @vara money
select @vara =(select ( Basic_salary*1.2*1.1*.97*.97 )from employeenew where Eid=@id)
RETURN(@vara+@incentive);

END;
GO;
SELECT Ename,dbo.GetIncentive1(Eid,2000) as tosalary from Employeenew;
go;

create function Getemployee(@Eid nchar(5))
RETURNS table
AS
return(select * from Employeenew where Eid=@eid);
go
select * from dbo.Getemployee(1);
go;

create function returnemployee()
returns table
as
return(select * from Employeenew)
go;
select * from dbo.returnemployee()