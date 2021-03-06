CREATE DATABASE Vocabulary
GO
USE [Vocabulary]
GO
/****** Object:  Table [dbo].[VOCABULARY]    Script Date: 9/27/2020 4:02:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VOCABULARY](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WORD] [nvarchar](255) NULL,
	[ENGLISH] [nchar](255) NULL,
	[VIETNAMESE] [nvarchar](255) NULL,
	[SPELLING] [nvarchar](255) NULL
) ON [PRIMARY]
GO
