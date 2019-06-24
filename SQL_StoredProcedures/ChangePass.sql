USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[ChangePass]    Script Date: 20/06/2019 16:50:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars>
-- Create date: <06-04-2019>
-- Description:	<Wachtwoord veranderen>
-- =============================================

CREATE PROCEDURE [dbo].[ChangePass]
	-- parameters
	@in_Username nvarchar(64),
	@in_NewPass nvarchar(64),
	@in_ReturnToLogin int,
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;
	
	-- get AccountID of currently logged in user
	declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username
	
	UPDATE Accounts SET MD5Password=@in_NewPass WHERE AccountID=@AccID

	INSERT INTO ActionHistory(AccountID, Type, Description, DateExecuted, FromIP) VALUES (@AccID, 'PassChangeSucces', 'User (' + @in_Username + ') changed password successfully', GETDATE(), @in_IP)

	if(@in_ReturnToLogin=1) begin
		return 1
	end
	else begin
		return 2
	end
END
GO

