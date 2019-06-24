USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Load_Contract_Hours]    Script Date: 20/06/2019 16:51:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Juul Winthaegen>
-- Create date: <16-04-2019>
-- Description:	<Contract uren opvragen>
-- =============================================

CREATE PROCEDURE [dbo].[Load_Contract_Hours]
	-- parameters
	@in_Username nvarchar(64),
	@in_SelectedFirstName nvarchar(64),
	@in_SelectedMiddleName nvarchar(64) = null,
	@in_SelectedFamilyName nvarchar(64),
	@in_SelectedWeek int,
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;

declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username

	declare @AccIDEmployee int

	if(@in_SelectedMiddleName IS NOT NULL) begin -- if the employee does not have a middle name
		SELECT @AccIDEmployee=AccountID FROM Employees WHERE FirstName=@in_SelectedFirstName AND FamilyName=@in_SelectedFamilyName AND MiddleName=@in_SelectedMiddleName
	end
	else begin
		SELECT @AccIDEmployee=AccountID FROM Employees WHERE FirstName=@in_SelectedFirstName AND FamilyName=@in_SelectedFamilyName
	end

	declare @UsernameEmployee nvarchar(64)
	SELECT @UsernameEmployee=Username FROM Accounts WHERE AccountID=@AccIDEmployee

	declare @ContractHours int
	SELECT @ContractHours=ContractHours FROM Employees WHERE AccountID=@AccIDEmployee
	
	select @ContractHours
END
GO

