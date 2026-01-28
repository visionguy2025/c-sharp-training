/* 
—————————————————————————————————————————————————————————————————————
######################## TASK 1 INSTRUCTIONS ########################
—————————————————————————————————————————————————————————————————————
1.SchoolDB database-ni yaradin. 
Students cedveli olacag columnlari bunlardir(Id,FullName,Age,Email,Score). ID özü auto incrementdir,FUllname null ola bilmez maksiumum 100 simvoldan ibaret ola biler,Age 6 ve 20 yash araliginda ola biler,Email unikal olmalidir,Score un default deyer 0dir 0 ve 100 araliginda deyer ala biler.
1.Students cədvəlinə 5 tələbə əlavə edin
2.Students cədvəlinə yeni sütun əlavə edin
3.Score-u 90-dan yuxarı olan tələbələrin Email-lərini yeniləyin
4. Yaş 10-dan kiçik olan tələbələri silin
5.Score üçün yeni şərt əlavə edin(score yalniz 5 e bolunen edeler olmalidir)
6.“TopStudents” adlı cədvəl yaradin ID,FullName,Score olsun  (Students cədvəlindən Score > 90 olanları TopStudents-ə insert edin)--- dememisem arasdira bilersiniz....
—————————————————————————————————————————————————————————————————————
*/

/* CREATE NEW DATABASE */
create database SchoolDB;

/* SELECT CREATED THAT NEW DATABASE */
use SchoolDB;

/* CREATE NEW TABLE INSIDE DATABASE */
create table Students(
	Id int primary key identity,
	FullName nvarchar(100) not null,
	Age smallint check(Age>=6 and Age<=20),
	Email varchar(35) unique,
	Score int check(Score>=0 and Score<=100)
);

/* BRING WHOLE SELECTED TABLE */
select * from Students;
--select * from Students order by Id asc;

/* ADD NEW DATA INTO THE TABLE */
insert into Students(FullName, Age, Email, Score) 
values
(N'Wade Wilson', 20, 'dondeestalabiblioteka@gmail.com', 99),
(N'Rick Sanchez', 6, 'rick2017@gmail.com', 50),
(N'Lorem Ipsum', 17, 'helloworld@gmail.com', 100),
(N'Uncle Dedeqorquud', 10, 'koroglununatasininadi@gmail.com', 0),
(N'John Smith', 17, 'untitled@gmail.com', 5);

/* ADD NEW FIELD/COLUMN TO THE TABLE NAMED GRADE WITH CONSTRAINT */
alter table Students add Grade int check(Grade>=1 and Grade <=11);

/* MANUALLY UPDATE EACH EXIST DATA TO PRETEND NEW ADDED FIELD'S NULL DATA */
update Students set Grade=5 where Id=1;
update Students set Grade=10 where Id=2;
update Students set Grade=8 where Id=5;
update Students set Grade=1 where Grade is null;

/* UPDATE EMAIL FIELD OF STUDENTS WHO HAS HIGHER SCORE THAN 90 */
update Students set Email='u_'+Email where Score>90;

/* DELETE STUDENTS WHO HAS LOWER AGE THAN GIVEN */
delete Students where Age<10;

/* TO RENEW SCORE CONSTRAINT, REMOVING CONSTRINAT, THEN REMOVE COLUMN, THEN ADD NEW ONE */
alter table Students drop constraint CK__Students__Score__4CA06362;
alter table Students drop column Score;
alter table Students add Score int check(Score%5=0);

/* MANUALLY FILLING RENEWED COLUMN'S NULL DATA WITH CUSTOM VALUES */
update Students set Score=95 where Id=1;
--update Students set Score=100 where Id=2;
update Students set Score=0 where Id=3;
update Students set Score=55 where Id=4;
update Students set Score=20 where Id=5;

/* CREATE NEW TABLE */
create table TopStudents(
	Id int primary key identity,
	FullName nvarchar(100) not null unique,
	Score int check(Score>90)
);

/* SHOW NEW TABLE */
select * from TopStudents;

/* REMOVE CONSTRAINT THEN COLUMN SELF AND ADD ANOTHER COLUMN FOR RELATION */
alter table TopStudents drop constraint UQ__TopStude__89C60F11131A618C;
alter table TopStudents drop column FullName;
alter table TopStudents add StudentId int foreign key references Students(Id);

/* ADD STUDENT TABLE'S FILTERED DATA INTO TOPSTUDENTS TABLE */
insert into TopStudents(Score, StudentId) select Score, Id from Students where Score>90;
