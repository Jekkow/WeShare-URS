USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[SessionCheck]    Script Date: 20/06/2019 16:52:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars>
-- Create date: <10-04-2019>
-- Description:	<Controleren of vanaf hetzelfde IP nog een sessie open is>
-- =============================================

CREATE PROCEDURE [dbo].[SessionCheck]
	-- parameters
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;

	-- this procedure executes as soon as the program launches

	-- get the SessionID of the current IP
	declare @SessID int
	SELECT @SessID=SessionID FROM Sessions WHERE FromIP=@in_IP

	-- get the AccountID of the current session
	declare @AccID int
	SELECT @AccID=AccountID FROM Sessions WHERE FromIP=@in_IP

	-- get the username
	declare @SessUname nvarchar(64)
	SELECT @SessUname=Username FROM Accounts WHERE AccountID=@AccID

	-- get the password
	declare @SessPass nvarchar(64)
	SELECT @SessPass=MD5Password FROM Accounts WHERE AccountID=@AccID
	
	if (@SessID > 0 AND @SessID IS NOT NULL) begin -- if the SessionID exists, send the username and password to the user so they can automatically be logged in
		select @SessUname, @SessPass
		return 1
	end
END
GO

