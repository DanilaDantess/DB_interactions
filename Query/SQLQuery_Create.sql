CREATE DATABASE [load_CSV]
GO

USE [load_CSV]
GO

/****** Object:  Table [dbo].[Test_Table]    Script Date: 08.06.2022 11:54:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Test_Table](
	[Id] [int] NOT NULL,
	[Vremya] [time](0) NOT NULL,
	[Ms] [smallint] NOT NULL,
	[Kontroller] [tinyint] NOT NULL,
	[Sila_tyagi] [decimal](6, 3) NOT NULL,
	[Napryajenie] [decimal](10, 6) NOT NULL,
	[Tok_generatora] [decimal](10, 7) NOT NULL,
	[Tor_kompressora] [decimal](15, 10) NOT NULL,
	[Temp_gazov_B1] [smallint] NOT NULL,
	[Temp_gazov_A5] [smallint] NOT NULL,
	[Tok_ADT] [decimal](15, 10) NOT NULL,
	[Vyhod_TNVD] [smallint] NOT NULL,
	[Chastota_vrascheniya] [smallint] NOT NULL
) ON [PRIMARY]
GO


