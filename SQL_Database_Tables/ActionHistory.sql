USE [WURS]
GO

/****** Object:  Table [dbo].[ActionHistory]    Script Date: 20/06/2019 16:53:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ActionHistory](
	[ActionID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[Type] [varchar](64) NOT NULL,
	[Description] [varchar](64) NULL,
	[DateExecuted] [datetime] NOT NULL,
	[FromIP] [varchar](16) NOT NULL,
 CONSTRAINT [PK_ActionHistory] PRIMARY KEY CLUSTERED 
(
	[ActionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ActionHistory] ADD  CONSTRAINT [DF_ActionHistory_DateExecuted]  DEFAULT (getdate()) FOR [DateExecuted]
GO

