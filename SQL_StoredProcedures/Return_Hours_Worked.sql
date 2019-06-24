USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Return_Hours_Worked]    Script Date: 20/06/2019 16:52:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars>
-- Create date: <17-04-2019>
-- Description:	<Gewerkte uren van deze maand naar code sturen>
-- =============================================

CREATE PROCEDURE [dbo].[Return_Hours_Worked]
	-- parameters
	@in_Username nvarchar(64),
	@in_CurrentMonth int,
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;

	declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username

	declare @FifthWeek float = 0
	declare @WorkedThisYear float = 0
	declare @FirstWeek float, @SecondWeek float, @ThirdWeek float, @FourthWeek float

	if(@in_CurrentMonth=1) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=1
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=2
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=3
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=4
	end
	else if(@in_CurrentMonth=2) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=5
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=6
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=7
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=8
	end
	else if(@in_CurrentMonth=3) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=9
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=10
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=11
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=12
		SELECT @FifthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=13
	end
	else if(@in_CurrentMonth=4) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=14
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=15
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=16
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=17
	end
	else if(@in_CurrentMonth=5) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=18
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=19
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=20
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=21
	end
	else if(@in_CurrentMonth=6) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=22
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=23
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=24
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=25
		SELECT @FifthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=26
	end
	else if(@in_CurrentMonth=7) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=27
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=28
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=29
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=30
	end
	else if(@in_CurrentMonth=8) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=31
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=32
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=33
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=34
	end
	else if(@in_CurrentMonth=9) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=35
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=36
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=37
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=38
		SELECT @FifthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=39
	end
	else if(@in_CurrentMonth=10) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=40
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=41
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=42
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=43
	end
	else if(@in_CurrentMonth=11) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=44
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=45
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=46
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=47
	end
	else if(@in_CurrentMonth=12) begin
		SELECT @FirstWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=48
		SELECT @SecondWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=49
		SELECT @ThirdWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=50
		SELECT @FourthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=51
		SELECT @FifthWeek=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID AND Week=52
	end
	else if(@in_CurrentMonth=20) begin
		SELECT @WorkedThisYear=SUM(WorkedHours) FROM Hours WHERE AccountID=@AccID
	end

	select @FirstWeek, @SecondWeek, @ThirdWeek, @FourthWeek, @FifthWeek, @WorkedThisYear
END
GO

