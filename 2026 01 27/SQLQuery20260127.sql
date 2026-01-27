/* CREATE DATABASE */
create database VisionFsDb;

/* SELECT DATABASE */
use VisionFsDb;

/* CREATE TABLE */
create table Students(
	Id int primary key identity, --or identity(1, 10)
	[Name] nvarchar(25) not null,
	Surname nvarchar(35) Default(N'Filankeov'),
	Email varchar(50) unique,
	Age smallint Check(Age>0 and Age<150)
	/* or , Check(Age>0) */
);

/* CREATE NEW TABLE */
insert into Students([Name], Surname, Email, Age) 
values
	('Lorem', 'Ipsum', 'loremipsum2026@gmail.com', 30),
	('Qwerty', 'Test', 'loremipsum2077@gmail.com', 19);

/* EDIT CONSTRAINT OF FIELD */
alter table Students alter column Age smallint;
alter table Students add check (Age>0 and Age<100);

/* BRING ALL TABLE */
select * from Students;

/*  */
--...
