/*
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
########################################### OBJECTIVE 1 INSTRUCTIONS ###########################################
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
1. MS SQL-de  Procedur və Function ,Trigger,arasdirirsiniz ve Function və procedurun ferqlerine baxirsiniz
2.Library database-i qurursunuz
Books
 - Id
 - AuthorId
 - Name - max 100, min 2
 - PageCount - min 10
Authors
 - Id
 - Name
 - Surname
Books ve Authors table-lariniz olsun
 (one to many realtion) Id,Name,PageCount ve
 AuthorFullName columnlarinin valuelarini
qaytaran bir VIEW yaradin
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/

CREATE DATABASE Library;

USE Library;

CREATE TABLE Authors(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(16) NOT NULL CHECK(LEN([Name])>2),
	Surname NVARCHAR(16) NOT NULL CHECK(LEN(Surname)>2)
);
CREATE TABLE Books(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(40) NOT NULL,
	[PageCount] INT DEFAULT(0),
	AuthorId INT FOREIGN KEY REFERENCES Authors(Id)
);

INSERT INTO Authors([Name], Surname) VALUES 
	('John', 'Doe'),
	('Jane', 'Smith'),
	('Robert', 'Brown'),
	('Emily', 'Johnson');

INSERT INTO Books([Name], [PageCount], AuthorId) VALUES 
	('The Lost Kingdom', 350, 1),
	('Secrets of the Forest', 280, 1),
	('City of Dreams', 400, 1),
	('A New Beginning', 250, 2),
	('The Silent Echo', 300, 2),
	('Journey Through Time', 500, 3),
	('Whispers of the Past', 220, 3),
	('The Final Hour', 450, 4);

CREATE VIEW SeeBookDetails AS 
SELECT b.Id AS ID, b.[Name] AS Title, b.[PageCount] AS Pages, a.[Name]+' '+a.Surname AS Author FROM Books b 
JOIN Authors a ON b.AuthorId=a.Id;

SELECT * FROM SeeBookDetails;

/*
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
########################################### OBJECTIVE 2 INSTRUCTIONS ###########################################
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Gonderilmis axtaris deyirene gore hemin axtaris
 deyeri Boook.name ve ya Author.Name olan Book-lari
Id,Name,PageCount,AuthorFullName columnlari seklinde
 gosteren procedure yazin
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/

CREATE PROCEDURE SearchBook @searchInput NVARCHAR(30) AS 
BEGIN
	SELECT b.Id AS ID, b.[Name] AS Title, b.[PageCount] AS Pages, a.[Name]+' '+a.Surname AS Author FROM Books b 
	JOIN Authors a ON b.AuthorId=a.Id WHERE CHARINDEX(@searchInput, a.[Name])>0 OR CHARINDEX(@searchInput, b.[Name])>0;
END;

EXEC SearchBook @searchInput='in';

/*
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
########################################### OBJECTIVE 3 INSTRUCTIONS ###########################################
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Bir Function yaradin.MinPageCount parametri qebul etsin.Default deyeri 10 olsun;
PageCount gonderilmis deyerden boyuk olan kitablarin sayini qaytarsin.
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/

CREATE FUNCTION Untitled(@MinPageCount INT = 10) RETURNS INT 
AS 
BEGIN 
	DECLARE @BookCount INT;
	SELECT @BookCount=COUNT([Name]) FROM Books WHERE [PageCount] >= @MinPageCount;
	RETURN @BookCount;
END;

SELECT dbo.Untitled(DEFAULT); -- OUTPUT: 8
SELECT dbo.Untitled(400); -- OUTPUT: 3
SELECT dbo.Untitled(500); -- OUTPUT: 1
SELECT dbo.Untitled(0); -- OUTPUT: 8

/*
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
########################################### OBJECTIVE 4 INSTRUCTIONS ###########################################
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
DeletedBooks table yaradin
Id,AuthorId,Name,PageCount
trigger yaradirsiz.
Books tablesindən kitab silinən zaman silinmiş kitab deleted books tablesinə düşsün
Birinci dbdesigner-de sturukturu qurub onun seklini atirsiniz sonra queryler
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/

CREATE TABLE DeletedBooks(
	Id INT PRIMARY KEY,
	[Name] NVARCHAR(40) NOT NULL,
	[PageCount] INT DEFAULT(0),
	AuthorId INT REFERENCES Authors(Id)
);

SELECT * FROM Books;
SELECT * FROM DeletedBooks;

CREATE TRIGGER SaveOnDeletedBooksByRemove 
ON Books 
AFTER DELETE  -- FOR AFTER INSTEAD | CREATE UPDATE DELETE INSERT ...
AS 
BEGIN 
	INSERT INTO DeletedBooks(Id, [Name], [PageCount], AuthorId) 
		SELECT Id, [Name], [PageCount], AuthorId FROM deleted;
END;

DELETE FROM Books WHERE Id=5;

SELECT * FROM Books;
SELECT * FROM DeletedBooks;

/*
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
