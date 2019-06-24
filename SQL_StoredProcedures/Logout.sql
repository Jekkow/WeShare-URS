USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Logout]    Script Date: 20/06/2019 16:52:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars>
-- Create date: <10-04-2019>
-- Description:	<Uitloggen en de sessie eindigen>
-- =============================================

CREATE PROCEDURE [dbo].[Logout]
	-- parameters
	@in_Username nvarchar(64),
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;
	
	-- allow login attempt to go through first 3 times
	declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username
	
	INSERT INTO ActionHistory (AccountID, Type, Description, DateExecuted, FromIP) VALUES (@AccID, 'LogOutSuccess', @in_Username + ' logged out successfully', GETDATE(), @in_IP)

	DELETE FROM Sessions WHERE AccountID=@AccID and FromIP=@in_IP -- delete the user's session

	if(@AccID IS NOT NULL) begin -- if the AccountID is not null, return a value
		return 1
	end
END
GO

