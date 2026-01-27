create database SchoolDB;

use SchoolDB;

create table Students(
	Id int primary key identity,
	FullName nvarchar(100) not null,
	Age smallint check(Age>=6 and Age<=20),
	Email varchar(35) unique,
	Score int check(Score>=0 and Score<=100)
);

select * from Students;

insert into Students(FullName, Age, Email, Score) 
values
(N'Wade Wilson', 20, 'dondeestalabiblioteka@gmail.com', 99),
(N'Rick Sanchez', 6, 'rick2017@gmail.com', 50),
(N'Lorem Ipsum', 17, 'helloworld@gmail.com', 100),
(N'Uncle Dedeqorquud', 10, 'koroglununatasininadi@gmail.com', 0),
(N'John Smith', 17, 'untitled@gmail.com', 5);

alter table Students add Grade int check(Grade>=1 and Grade <=11);

update Students set Grade=5 where Id=1;
update Students set Grade=10 where Id=2;
update Students set Grade=8 where Id=5;
update Students set Grade=1 where Grade is null;

update Students set Email='updatedemail@gmail.com' where Score>90;

delete Students where Age<10;

/* couldn't make it, research and get done !!! */
--update Students set Score=null;
--alter table Students drop column CK__Students__Score;
--alter table Students add Score int check(Score%5=0);

create table TopStudents(
	Id int primary key identity,
	FullName nvarchar(100) not null unique,
	Score int check(Score>90)
);

/* couldn't make it, research and get done !!! */
--select * from Students where Score>90 insert into TopStudents(FullName, Score) values(FullName, Score);
