CREATE DATABASE STUDATA;
USE STUDATA;
CREATE TABLE STUDENT1
	(STUID INT NOT NULL,
	StuName VARCHAR (50) NOT NULL,
	department VARCHAR (50) NOT NULL,
    age INT NOT NULL);
	drop table student1;
	select * from STUDENT1;
	INSERT INTO student1 VALUES (1,'BINCY','CSE',20);
INSERT INTO student1 VALUES (2, 'ARYA','ME',20);
INSERT INTO student1 VALUES (3, 'AFSANA','EC',21);
INSERT INTO student1 VALUES (4, 'TINCY','CSE',20);
INSERT INTO student1 VALUES (5, 'MRIDHU','ME',20);

DROP DATABASE STUDENTNEW1;
DROP DATABASE STUDENTDBNEW1;