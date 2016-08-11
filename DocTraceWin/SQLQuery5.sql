USE [doctrace]
GO

/****** Object:  Table [dbo].[Transaction]    Script Date: 03/11/2010 16:54:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Transaction](
	[Sequence] [int] NOT NULL,
	[BarCode] [varchar](10) NULL,
	[Title] [varchar](50) NULL,
	[DocDate] [datetime] NULL,
	[Snapshot] [varbinary](max) NULL,
	[Username] [varchar](20) NULL,
	[DateCreated] [datetime] NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Sequence] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [doctrace]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 03/11/2010 16:54:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Users](
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](20) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

