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
	[Vremya] [time](7) NOT NULL,
	[Ms] [smallint] NOT NULL,
	[Kontroller] [tinyint] NOT NULL,
	[Sila_tyagi] [numeric](6, 3) NOT NULL,
	[Napryajenie] [numeric](10, 6) NOT NULL,
	[Tok_generatora] [numeric](10, 7) NOT NULL,
	[Tor_kompressora] [numeric](10, 9) NOT NULL,
	[Temp_gazov_B1] [smallint] NOT NULL,
	[Temp_gazov_A5] [smallint] NOT NULL,
	[Tok_ADT] [numeric](10, 9) NOT NULL,
	[Vyhod_TNVD] [smallint] NOT NULL,
	[Chastota_vrascheniya] [smallint] NOT NULL
) ON [PRIMARY]
GO


