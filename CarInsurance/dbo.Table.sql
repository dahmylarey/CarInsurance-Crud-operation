﻿CREATE TABLE [dbo].[Insurees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (0,1),
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[EmailAddress] NVARCHAR(50) NOT NULL,
	[DateOfBirth] DATETIME NOT NULL,
	[CarYear] INT NOT NULL,
	[CarMake] NVARCHAR(50) NOT NULL,
	[CarModel] NVARCHAR(50) NOT NULL,
	[DUI] BIT NOT NULL,
	[SpeedingTickets] INT NOT NULL,
	[CoverageType] BIT NOT NULL,
	[Quote] MONEY NOT NULL,
)
