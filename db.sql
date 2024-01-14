USE [build42820]
GO
/****** Object:  StoredProcedure [dbo].[CreateTables]    Script Date: 5/4/2020 5:19:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CreateTables] AS
BEGIN

IF EXISTS (SELECT * FROM sys.tables WHERE NAME = 'Users') 
	DROP TABLE [Users]

CREATE TABLE [dbo].[Users]
	(
		[Id] INT IDENTITY(1,1) NOT NULL,
		[WorkerId] NVARCHAR(50) NULL,
		[Login] NVARCHAR(50) UNIQUE NOT NULL,
		[Password] NVARCHAR(50) NOT NULL,
		[Name] NVARCHAR(50) NOT NULL,
		[Surname] NVARCHAR(50) NOT NULL,
		[PhoneNumber] NVARCHAR(50) DEFAULT ('не указан'),
		[Address] NVARCHAR(50) DEFAULT ('не указан'),
		[DateOfRegistration] DATE DEFAULT (GETDATE()),
		PRIMARY KEY ([Id]),
		CONSTRAINT CheckDateOfRegistration CHECK ([DateOfRegistration] <= GETDATE())
	)

CREATE UNIQUE NONCLUSTERED INDEX allowed_null
	ON [dbo].[Users] ([WorkerId])
	WHERE [WorkerId] IS NOT NULL

IF EXISTS (SELECT * FROM sys.tables WHERE NAME = 'Books') 
	DROP TABLE [Books]

CREATE TABLE [dbo].[Books]
	(
		[Id] INT IDENTITY(1,1) NOT NULL,
		[Name] NVARCHAR(50) NOT NULL,
		[Autor] NVARCHAR(50) NOT NULL,
		[Year] INT NULL,
		[PlaceOfPublication] NVARCHAR(50) NULL,
		[Publisher] NVARCHAR(50) NULL,
		[Theme] NVARCHAR(50) NOT NULL,
		[Copies] INT DEFAULT 0,
		PRIMARY KEY ([Id]),
		CONSTRAINT CheckYear CHECK ([Year] >= 1000 AND [Year] <= DATEPART(year, GETDATE()))
	)

IF EXISTS (SELECT * FROM sys.tables WHERE NAME = 'Operations') 
	DROP TABLE [Operations]

CREATE TABLE [dbo].[Operations]
	(
		[Id] INT IDENTITY(1,1) NOT NULL,
		[Date] DATE DEFAULT (GETDATE()),
		[ClientId] INT NOT NULL,
		[BookId] INT NOT NULL,
		[Type] NVARCHAR(50) NOT NULL,
		PRIMARY KEY (Id),
		FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Users] ([Id]),
		FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]), 
		CONSTRAINT CheckDate1 CHECK ([Date] <= GETDATE()),
		CONSTRAINT CheckType CHECK ([Type] IN ('взял', 'вернул'))
	)

IF EXISTS (SELECT * FROM sys.tables WHERE NAME = 'Clients') 
	DROP TABLE [Clients]

CREATE TABLE [dbo].[Clients]
	(
		[ClientId] INT NOT NULL,
		[BookId] INT NOT NULL,
		[Date] DATE NULL,
		[Debt] NVARCHAR(50) NOT NULL,
		FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Users] ([Id]),
		FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]),
		CONSTRAINT CheckDate2 CHECK ([Date] <= GETDATE()),
		CONSTRAINT CheckDebt CHECK ([Debt] IN ('нет', 'есть'))
	)
END;
