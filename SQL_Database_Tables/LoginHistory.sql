USE [WURS]
GO

/****** Object:  Table [dbo].[LoginHistory]    Script Date: 20/06/2019 16:54:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LoginHistory](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[SessionID] [int] NOT NULL,
	[LoggedInFrom] [varchar](16) NOT NULL,
	[LoggedInDate] [datetime] NOT NULL,
	[LoggedOutDate] [datetime] NULL,
 CONSTRAINT [PK_LoginHistory] PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LoginHistory] ADD  CONSTRAINT [DF_LoginHistory_LoggedInDate]  DEFAULT (getdate()) FOR [LoggedInDate]
GO

