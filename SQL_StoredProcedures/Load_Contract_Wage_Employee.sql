USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Load_Contract_Wage_Employee]    Script Date: 20/06/2019 16:51:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Lars Smeets>
-- Create date: <17-04-2019>
-- Description:	<Contract loon opvragen>
-- =============================================

CREATE PROCEDURE [dbo].[Load_Contract_Wage_Employee]
	-- parameters
	@in_Username nvarchar(64),
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;

	declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username

	declare @ContractWage int
	SELECT @ContractWage=HourlyWage FROM Employees WHERE AccountID=@AccID
	
	select @ContractWage
END
GO

