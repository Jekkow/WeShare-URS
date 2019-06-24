USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Insert_Hours]    Script Date: 20/06/2019 16:51:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Groep>
-- Create date: <10-04-2019>
-- Description:	<Uren toevoegen in database>
-- =============================================

CREATE PROCEDURE [dbo].[Insert_Hours]
	-- parameters
	@in_Username nvarchar(64),
	@in_Week int,
	@in_Day int,
	@in_Year int,
	@in_WorkedHours float,
	@in_ActivityType nvarchar(64),
	@in_Comments nvarchar(256),
	@in_Sick int,
	@in_Home int,
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;
	
	-- get AccountID of currently logged in user
	declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username
	
	DELETE FROM Hours WHERE Day=@in_Day AND Comments='Geen commentaar' AND Week=@in_Week-- verwijder oude uren die standaard worden aangemaakt
	INSERT INTO Hours (AccountID, Week, Day, Year, WorkedHours, ActivityType, Comments, Sick, Home) VALUES (@AccID, @in_Week, @in_Day, @in_Year, @in_WorkedHours, @in_ActivityType, @in_Comments, @in_Sick, @in_Home)

END
GO

