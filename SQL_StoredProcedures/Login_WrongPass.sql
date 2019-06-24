USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Login_WrongPass]    Script Date: 20/06/2019 16:52:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars>
-- Create date: <05-04-2019>
-- Description:	<Gebruiker probeert in te loggen met verkeerd wachtwoord of gebruikersnaam>
-- =============================================

CREATE PROCEDURE [dbo].[Login_WrongPass]
	-- parameters
	@in_Username nvarchar(64),
	@in_Password nvarchar(64),
	@in_Attempt int,
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;
	
	-- allow login attempt to go through first 3 times
	declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username

	if (@AccID IS NULL) begin -- if the user tried to login with a non-existant username
		return 4
	end
	else begin
		declare @PasswordExists int
		SELECT @PasswordExists=MD5Password FROM Accounts WHERE AccountID=@AccID AND MD5Password=@in_Password
		if(@PasswordExists IS NULL) begin -- if the user tried to login with a wrong password
			return 5
		end
		else begin
			declare @LastBlockedTime datetime
			SELECT @LastBlockedTime=LastBlockedTime FROM Accounts WHERE Username=@in_Username
	
			if(@LastBlockedTime>GETDATE()) begin
				return 1 -- user can't login, still blocked
			end
			else begin
				UPDATE Accounts SET CanLogin=1 WHERE AccountID=@AccID
			end
	
			if(@in_Attempt < 3) begin
				INSERT INTO ActionHistory (AccountID, Type, Description, DateExecuted, FromIP) VALUES (@AccID, 'LogInAttemptWrongPass', 'User attempted to log in with wrong password', GETDATE(), @in_IP)
			end
			else begin
				INSERT INTO ActionHistory (AccountID, Type, Description, DateExecuted, FromIP) VALUES (@AccID, 'LogInBlocked', 'User attempted to log in 3 times with wrong password', GETDATE(), @in_IP)
				UPDATE Accounts SET CanLogin=0,LastBlockedTime=DATEADD(minute, 5, GETDATE()) WHERE AccountID=@AccID -- block user for 5 minutes
				return 3
			end
		end
	end
END
GO

