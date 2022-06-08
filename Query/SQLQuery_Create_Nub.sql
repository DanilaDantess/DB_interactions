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
	[Kontroller] [int] NOT NULL,
	[Sila_tyagi] [nvarchar](7) NOT NULL,
	[Napryajenie] [nvarchar](18) NOT NULL,
	[Tok_generatora] [nvarchar](18) NOT NULL,
	[Tor_kompressora] [nvarchar](18) NOT NULL,
	[Temp_gazov_B1] [int] NOT NULL,
	[Temp_gazov_A5] [int] NOT NULL,
	[Tok_ADT] [nvarchar](18) NOT NULL,
	[Vyhod_TNVD] [smallint] NOT NULL,
	[Chastota_vrascheniya] [nvarchar](18) NOT NULL
) ON [PRIMARY]
GO


