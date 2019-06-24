USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 20/06/2019 16:52:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars>
-- Create date: <05-04-2019>
-- Description:	<Controleren of een gebruiker geblokkeerd is of niet, LoginHistory aanpassen en een sessie aanmaken>
-- =============================================

CREATE PROCEDURE [dbo].[Login]
	-- parameters
	@in_Username nvarchar(64),
	@in_Password nvarchar(64),
	@in_Attempt int,
	@in_FromSession int,
	@in_IP nvarchar(16)
AS
ALTER TABLE Accounts
ALTER COLUMN MD5Password VARCHAR(64)
COLLATE Latin1_General_CS_AS
BEGIN
	SET NOCOUNT ON;
	
	-- get AccountID of currently logged in user
	declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username AND MD5Password=@in_Password
	
	-- get the last time the currently logged in user was blocked
	declare @LastBlockedTime datetime
	SELECT @LastBlockedTime=LastBlockedTime FROM Accounts WHERE Username=@in_Username AND MD5Password=@in_Password

	-- get the function of the currently logged in user
	declare @Func nvarchar(64)
	SELECT @Func=[Function] FROM Employees WHERE AccountID=@AccID

	-- check if user is blocked
	if(@LastBlockedTime>GETDATE()) begin
		return 50 -- user can't login, still blocked
	end
	else begin
		UPDATE Accounts SET CanLogin=1 WHERE AccountID=@AccID
	end
	
	if(@in_Attempt < 3) begin -- allow login attempt to go through first 3 times
		INSERT INTO ActionHistory (AccountID, Type, Description, DateExecuted, FromIP) VALUES (@AccID, 'LogInAttempt', 'User attempted to log in', GETDATE(), @in_IP)
	end
	else begin -- user attempted to log in more than 3 times, block login for 5 minutes
		INSERT INTO ActionHistory (AccountID, Type, Description, DateExecuted, FromIP) VALUES (@AccID, 'LogInBlocked', 'User attempted to log in 3 times with wrong password', GETDATE(), @in_IP)
		UPDATE Accounts SET CanLogin=0,LastBlockedTime=DATEADD(minute, 5, GETDATE()) WHERE AccountID=@AccID -- block user for 5 minutes
		return 3
	end
	
	if(@in_FromSession = 0) begin -- if the user does not  have an active sessions, create one
		INSERT INTO Sessions (AccountID, FromIP, DateLoggedIn) VALUES (@AccID, @in_IP, GETDATE())
	end

	-- get the session ID
	declare @SessID int
	SELECT @SessID=SessionID FROM Sessions WHERE AccountID=@AccID
	
	INSERT INTO LoginHistory (AccountID, SessionID, LoggedInFrom, LoggedInDate) VALUES (@AccID, @SessID, @in_IP, GETDATE())
	INSERT INTO ActionHistory (AccountID, Type, Description, DateExecuted, FromIP) VALUES (@AccID, 'LogInSuccess', 'Logged in successfully', GETDATE(), @in_IP)

	if(@in_Password='FirstLogin') begin
		return 20
	end
	
	-- if the user is a manager, return a value so we can display the manager form
	if(@Func='Manager') begin
		return 10
	end
END
GO

