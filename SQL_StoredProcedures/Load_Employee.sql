USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Load_Employee]    Script Date: 20/06/2019 16:51:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars; Dammer, Jacco>
-- Create date: <11-04-2019>
-- Description:	<Medewerkers opvragen op basis van manager>
-- =============================================

CREATE PROCEDURE [dbo].[Load_Employee]
	-- parameters
	@in_Username nvarchar(64),
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;

	-- get AccountID of currently logged in user
	declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username

	-- get ManagerID of currently logged in user
	declare @ManagerID int
	SELECT @ManagerID=ManagerID FROM Employees WHERE ManagerID=@AccID

	-- select all employees the currently logged in user is a manager of
	select FirstName, MiddleName, FamilyName FROM Employees WHERE (ManagerID=@AccID AND [Function]='Medewerker') OR (AccountID=@AccID) ORDER BY FamilyName
	
END
GO

