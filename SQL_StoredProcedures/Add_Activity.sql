USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Add_Activity]    Script Date: 20/06/2019 16:49:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars>
-- Create date: <17-04-2019>
-- Description:	<Toevoegen van een activiteit door manager>
-- =============================================

CREATE PROCEDURE [dbo].[Add_Activity]
	-- parameters
	@in_Username nvarchar(64), --Username of Manager creating account
	@in_Name nvarchar(64),
	@in_Description nvarchar(256),
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;

	declare @AccID int 
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username

	INSERT INTO ActivityType (Name, Description) VALUES (@in_Name, @in_Description)
	INSERT INTO ActionHistory(AccountID, Type, Description, DateExecuted, FromIP) VALUES (@AccID, 'AddNewActivity', 'Manager (' + @in_Username + ') added a new activity (' + @in_Name + ')', GETDATE(), @in_IP)

END
GO

