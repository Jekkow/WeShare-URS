USE [WURS]
GO

/****** Object:  Table [dbo].[Hours]    Script Date: 20/06/2019 16:54:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Hours](
	[HoursID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[Week] [int] NOT NULL,
	[Day] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[WorkedHours] [float] NOT NULL,
	[ActivityType] [varchar](64) NOT NULL,
	[Comments] [varchar](256) NULL,
	[Approved] [int] NOT NULL,
	[Sick] [int] NULL,
	[Home] [int] NOT NULL,
 CONSTRAINT [PK_Hours] PRIMARY KEY CLUSTERED 
(
	[HoursID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Hours] ADD  CONSTRAINT [DF_Hours_Week]  DEFAULT ((0)) FOR [Week]
GO

ALTER TABLE [dbo].[Hours] ADD  CONSTRAINT [DF_Hours_WorkedHours]  DEFAULT ((0)) FOR [WorkedHours]
GO

ALTER TABLE [dbo].[Hours] ADD  CONSTRAINT [DF_Hours_ActivityType]  DEFAULT ((1)) FOR [ActivityType]
GO

ALTER TABLE [dbo].[Hours] ADD  CONSTRAINT [DF_Hours_Approved]  DEFAULT ((0)) FOR [Approved]
GO

ALTER TABLE [dbo].[Hours] ADD  CONSTRAINT [DF_Hours_Home]  DEFAULT ((0)) FOR [Home]
GO

