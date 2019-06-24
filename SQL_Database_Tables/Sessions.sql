USE [WURS]
GO

/****** Object:  Table [dbo].[Sessions]    Script Date: 20/06/2019 16:54:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sessions](
	[SessionID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[FromIP] [varchar](16) NOT NULL,
	[DateLoggedIn] [datetime] NOT NULL,
 CONSTRAINT [PK_Sessions] PRIMARY KEY CLUSTERED 
(
	[SessionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sessions] ADD  CONSTRAINT [DF_Sessions_DateLoggedIn]  DEFAULT (getdate()) FOR [DateLoggedIn]
GO

