USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Edit_Hours]    Script Date: 20/06/2019 16:50:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars; Dammer, Jacco>
-- Create date: <15-04-2019>
-- Description:	<Uren wijzigen van medewerker>
-- =============================================

CREATE PROCEDURE [dbo].[Edit_Hours]
	-- parameters
	@in_Username nvarchar(64),
	@in_SelectedFirstName nvarchar(64),
	@in_SelectedMiddleName nvarchar(64) = null,
	@in_SelectedFamilyName nvarchar(64),
	@in_SelectedWeek int,
	@in_MonApproved int,
	@in_TueApproved int,
	@in_WedApproved int,
	@in_ThuApproved int,
	@in_FriApproved int,
	@in_CommentsMon nvarchar(256),
	@in_CommentsTue nvarchar(256),
	@in_CommentsWed nvarchar(256),
	@in_CommentsThu nvarchar(256),
	@in_CommentsFri nvarchar(256),
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

	UPDATE Hours SET Approved=@in_MonApproved, Comments=@in_CommentsMon WHERE Day=1 AND Week=@in_SelectedWeek AND AccountID=@AccIDEmployee
	UPDATE Hours SET Approved=@in_TueApproved, Comments=@in_CommentsTue WHERE Day=2 AND Week=@in_SelectedWeek AND AccountID=@AccIDEmployee
	UPDATE Hours SET Approved=@in_WedApproved, Comments=@in_CommentsWed WHERE Day=3 AND Week=@in_SelectedWeek AND AccountID=@AccIDEmployee
	UPDATE Hours SET Approved=@in_ThuApproved, Comments=@in_CommentsThu WHERE Day=4 AND Week=@in_SelectedWeek AND AccountID=@AccIDEmployee
	UPDATE Hours SET Approved=@in_FriApproved, Comments=@in_CommentsFri WHERE Day=5 AND Week=@in_SelectedWeek AND AccountID=@AccIDEmployee
	
END
GO

