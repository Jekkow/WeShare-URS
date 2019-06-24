USE [WURS]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 20/06/2019 16:54:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[ManagerID] [int] NULL,
	[Email] [varchar](128) NULL,
	[FirstName] [varchar](32) NOT NULL,
	[MiddleName] [varchar](32) NULL,
	[FamilyName] [varchar](32) NULL,
	[Function] [varchar](64) NOT NULL,
	[InternalEmployee] [int] NOT NULL,
	[DistanceFromWork] [float] NULL,
	[ContractHours] [float] NULL,
	[HourlyWage] [float] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [DF_Employees_InternalEmployee]  DEFAULT ((1)) FOR [InternalEmployee]
GO

