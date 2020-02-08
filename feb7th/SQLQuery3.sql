select * from Coursetable
Go;
create Function Totalfee()

returns money
as
begin
Declare @tfee money;
select @tfee=sum(fees) from Coursetable;
return @tfee;
End;
go;
select dbo.Totalfee() as Totalfees;