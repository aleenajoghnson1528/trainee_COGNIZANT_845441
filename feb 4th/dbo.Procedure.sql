CREATE PROCEDURE [dbo].[InsertRecord]
	@Sid int,
	@Sname varchar(max),
	@Course varchar(max),
	@StartDate date
AS
	insert into student(Sid,Sname,Course,StartDate) values(@Sid,@Sname,@Course,@StartDate)

