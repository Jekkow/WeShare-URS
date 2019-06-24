USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Add_Employee]    Script Date: 20/06/2019 16:50:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars>
-- Create date: <08-04-2019>
-- Description:	<Medewerker toevoegen en account genereren>
-- =============================================

CREATE PROCEDURE [dbo].[Add_Employee]
	-- parameters
	@in_Username nvarchar(64), --Username of Manager creating account
	@in_ManagerUsername nvarchar(64), --Username of the Manager from the new Employee
	@in_Email nvarchar(128),
	@in_FirstName nvarchar(32),
	@in_MiddleName nvarchar(32) = NULL,
	@in_FamilyName nvarchar(32),
	@in_Function nvarchar(64),
	@in_InternalEmployee int = 1,
	@in_DistanceFromWork float,
	@in_ContractHours float,
	@in_HourlyWage float,
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;
	
	--==Declarations==--
	--First Three Letters of Family name
	declare @FirstThreeLetters nvarchar(3) 
	SELECT @FirstThreeLetters=substring(@in_FamilyName,1,3)

	--First Letter of First Name
	declare @FirstLetterFirstName nvarchar(1) 
	SELECT @FirstLetterFirstName=LEFT(@in_FirstName, 1)

	--Combine First Three Letters of Familiy Name with First Letter of First Name
	declare @ConvertedUsername nvarchar(64)
	SELECT @ConvertedUsername=CONCAT(@FirstThreeLetters,@FirstLetterFirstName)

	--Manager ID of logged in Manager
	declare @CurrentManagerID int 
	SELECT @CurrentManagerID=AccountID FROM Accounts WHERE Username=@in_Username

	--ManagerID of given Manager Name
	declare @ManagerID int 
	SELECT @ManagerID=AccountID FROM Employees WHERE FirstName=@in_ManagerUsername

	--Count of Converted Username
	declare @CountUsername int = 0 
	SELECT @CountUsername=count(Username) FROM Accounts WHERE Username LIKE substring(@ConvertedUsername,1,4)+'%'

	--If Converted Username exist, combine Username with Count
	if(@CountUsername > 0) begin 
		SELECT @ConvertedUsername=CONCAT(@ConvertedUsername,@CountUsername)
	end
	
	--==Inserts==--
	-- Create New Account
	INSERT INTO Accounts (Username, MD5Password, DateRegistered, AccessLevel, CanLogin) VALUES (@ConvertedUsername, 'FirstLogin', GETDATE(), 0, 1) 
	
	--Declade Account ID for new account
	declare @AccID int 
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@ConvertedUsername
	
	--Insert new Employee in Employee Table
	INSERT INTO Employees (AccountID, ManagerID, Email, FirstName, MiddleName, FamilyName, [Function], InternalEmployee, DistanceFromWork, ContractHours, HourlyWage) VALUES (@AccID, @ManagerID, @in_Email, @in_FirstName, @in_MiddleName, @in_FamilyName, @in_Function, @in_InternalEmployee, @in_DistanceFromWork, @in_ContractHours, @in_HourlyWage)
	
	--Insert CreateNewEmployee Activity in Action Table
	INSERT INTO ActionHistory(AccountID, Type, Description, DateExecuted, FromIP) VALUES (@CurrentManagerID, 'CreateNewEmployee', 'Manager (' + @in_Username + ') created a new employee (' + @ConvertedUsername + ')', GETDATE(), @in_IP)

	--Return ConvertedUsername for MessageBox popup
	select @ConvertedUsername
END
GO

