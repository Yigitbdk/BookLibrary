USE [BookLibrary]
GO

/****** Object: Table [dbo].[Reservations] Script Date: 18.09.2023 11:40:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reservations] (
    [ID]         INT  IDENTITY (1, 1) NOT NULL,
    [BookId]     INT  NOT NULL,
    [CustomerId] INT  NOT NULL,
    [DateTake]   DATE NOT NULL,
    [DateReturn] DATE NOT NULL
);

GO

/****** Object: Table [dbo].[Genre] Script Date: 18.09.2023 11:40:42 ******/
CREATE TABLE [dbo].[Genre] (
    [ID]    INT          IDENTITY (1, 1) NOT NULL,
    [Genre] VARCHAR (50) NOT NULL,
    [Date]  DATE         NOT NULL
);


GO
/****** Object: Table [dbo].[Customers] Script Date: 18.09.2023 11:40:37 ******/
CREATE TABLE [dbo].[Customers] (
    [ID]         INT          IDENTITY (1, 1) NOT NULL,
    [FkBookId]   INT          NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Surname]    VARCHAR (50) NOT NULL,
    [Age]        SMALLINT     NULL,
    [Male]       BIT          NULL,
    [CreateDate] DATE         NOT NULL,
    [TelNr]      VARCHAR (15) NULL
);

GO
/****** Object: Table [dbo].[Books] Script Date: 18.09.2023 11:40:29 ******/
CREATE TABLE [dbo].[Books] (
    [ID]         INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Writer]     VARCHAR (50) NOT NULL,
    [Genre]      VARCHAR (50) NOT NULL,
    [PageNumber] VARCHAR (50) NOT NULL,
    [RecordDate] DATE         NOT NULL,
    [CreateDate] DATE         NOT NULL
);