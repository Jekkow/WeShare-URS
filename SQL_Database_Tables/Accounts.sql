USE [WURS]
GO

/****** Object:  Table [dbo].[Accounts]    Script Date: 20/06/2019 16:53:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](64) NOT NULL,
	[MD5Password] [varchar](64) NULL,
	[DateRegistered] [datetime] NOT NULL,
	[AccessLevel] [int] NOT NULL,
	[CanLogin] [int] NOT NULL,
	[LastBlockedTime] [datetime] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [DF_Accounts_DateRegistered]  DEFAULT (getdate()) FOR [DateRegistered]
GO

ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [DF_Accounts_AccessLevel]  DEFAULT ((0)) FOR [AccessLevel]
GO

ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [DF_Accounts_CanLogin]  DEFAULT ((1)) FOR [CanLogin]
GO

