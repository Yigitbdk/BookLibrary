USE [BookLibrary]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/****** Object: Table [dbo].[Reservations] Script Date: 26.09.2023 09:52:01 ******/

CREATE TABLE [dbo].[Reservations] (
    [ID]         INT  IDENTITY (1, 1) NOT NULL,
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


/****** Object: Table [dbo].[Customers] Script Date: 26.09.2023 09:50:27 ******/

GO

CREATE TABLE [dbo].[Customers] (
    [ID]         INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Surname]    VARCHAR (50) NOT NULL,
    [Age]        SMALLINT     NULL,
    [Gender]     VARCHAR (50) NULL,
    [CreateDate] DATE         NOT NULL,
    [TelNo]      VARCHAR (15) NULL,
    [BookId]     INT          NULL
);

GO

CREATE TABLE [dbo].[Books] (
    [ID]         INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Writer]     VARCHAR (50) NOT NULL,
    [Genre]      VARCHAR (50) NOT NULL,
    [PageNumber] VARCHAR (50) NOT NULL,
    [RecordDate] DATE         NOT NULL,
    [CreateDate] DATE         NOT NULL
);
