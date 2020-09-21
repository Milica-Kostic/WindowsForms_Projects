USE TSQL
GO
--kreiramo tabelu Klijenti i u nju dodajemo sve kupce iz tabele Sales.Customers
CREATE TABLE dbo.Klijenti(
	KlijentID int IDENTITY PRIMARY KEY NOT NULL,
	Naziv nvarchar(40) NOT NULL,
	Kontakt nvarchar(30) NOT NULL,
	Grad nvarchar(15) NOT NULL,
	Zemlja nvarchar(15) NOT NULL,
	);
GO

INSERT INTO dbo.Klijenti(Naziv,Kontakt,Grad,Zemlja)
SELECT companyname,contactname,city,country
FROM Sales.Customers;
GO
SELECT * FROM dbo.Klijenti
GO
--kreiramo proceduru za poziv klijenata
CREATE PROC dbo.KlijentiSelect
AS
BEGIN TRY
SELECT KlijentID,Naziv,Kontakt,Grad,Zemlja
FROM dbo.Klijenti
ORDER BY KlijentID
RETURN 0;
END TRY
BEGIN CATCH
	RETURN @@ERROR;
END CATCH
GO

--update stored proc
CREATE PROC dbo.KlijentiUpdate
@klijentId int, @naziv nvarchar(40), @kontakt nvarchar(30), @grad nvarchar(15), @zemlja nvarchar(15)
AS
BEGIN TRY
UPDATE dbo.Klijenti
SET Naziv = @naziv, Kontakt = @kontakt, Grad =@grad, Zemlja=@zemlja
WHERE KlijentID = @klijentId
RETURN 0;
END TRY
BEGIN CATCH
	RETURN @@ERROR;
END CATCH
GO


--insert
CREATE PROC dbo.KlijentiInsert
@naziv nvarchar(40), @kontakt nvarchar(30), @grad nvarchar(15), @zemlja nvarchar(15)
AS
BEGIN TRY
INSERT INTO dbo.Klijenti
(Naziv,Kontakt,Grad,Zemlja)
VALUES
(@naziv,@kontakt,@grad, @zemlja)
RETURN 0;
END TRY
BEGIN CATCH
	RETURN @@ERROR;
END CATCH
GO
--delete
CREATE PROC dbo.KlijentiDelete
@klijentId int
AS
BEGIN TRY
DELETE FROM dbo.Klijenti 
WHERE KlijentID  = @klijentId
RETURN 0;
END TRY
BEGIN CATCH
	RETURN @@ERROR;
END CATCH
GO


