USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Return_Hours_Employee]    Script Date: 20/06/2019 16:52:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Smeets, Lars; Dammer, Jacco>
-- Create date: <11-04-2019>
-- Description:	<Uren naar code sturen>
-- =============================================

CREATE PROCEDURE [dbo].[Return_Hours_Employee]
	-- parameters
	@in_Username nvarchar(64),
	@in_SelectedWeek int,
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;

	declare @AccID int
	SELECT @AccID=AccountID FROM Accounts WHERE Username=@in_Username

	declare @WorkedHoursMon float, @WorkedHoursTue float, @WorkedHoursWed float, @WorkedHoursThu float, @WorkedHoursFri float
	SELECT @WorkedHoursMon=WorkedHours FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=1
	SELECT @WorkedHoursTue=WorkedHours FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=2
	SELECT @WorkedHoursWed=WorkedHours FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=3
	SELECT @WorkedHoursThu=WorkedHours FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=4
	SELECT @WorkedHoursFri=WorkedHours FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=5

	declare @ActivityTypeMon nvarchar(64), @ActivityTypeTue nvarchar(64), @ActivityTypeWed nvarchar(64), @ActivityTypeThu nvarchar(64), @ActivityTypeFri nvarchar(64)
	SELECT @ActivityTypeMon=ActivityType FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=1
	SELECT @ActivityTypeTue=ActivityType FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=2
	SELECT @ActivityTypeWed=ActivityType FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=3
	SELECT @ActivityTypeThu=ActivityType FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=4
	SELECT @ActivityTypeFri=ActivityType FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=5

	declare @CommentsMon nvarchar(256), @CommentsTue nvarchar(256), @CommentsWed nvarchar(256), @CommentsThu nvarchar(256), @CommentsFri nvarchar(256)
	SELECT @CommentsMon=Comments FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=1
	SELECT @CommentsTue=Comments FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=2
	SELECT @CommentsWed=Comments FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=3
	SELECT @CommentsThu=Comments FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=4
	SELECT @CommentsFri=Comments FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=5

	declare @SickMon int, @SickTue int, @SickWed int, @SickThu int, @SickFri int
	SELECT @SickMon=Sick FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=1
	SELECT @SickTue=Sick FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=2
	SELECT @SickWed=Sick FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=3
	SELECT @SickThu=Sick FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=4
	SELECT @SickFri=Sick FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=5

	declare @HomeMon int, @HomeTue int, @HomeWed int, @HomeThu int, @HomeFri int
	SELECT @HomeMon=Home FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=1
	SELECT @HomeTue=Home FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=2
	SELECT @HomeWed=Home FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=3
	SELECT @HomeThu=Home FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=4
	SELECT @HomeFri=Home FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=5

	declare @ApprovedMon int, @ApprovedTue int, @ApprovedWed int, @ApprovedThu int, @ApprovedFri int
	SELECT @ApprovedMon=Approved FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=1
	SELECT @ApprovedTue=Approved FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=2
	SELECT @ApprovedWed=Approved FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=3
	SELECT @ApprovedThu=Approved FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=4
	SELECT @ApprovedFri=Approved FROM Hours WHERE AccountID=@AccID AND Week=@in_SelectedWeek AND Day=5

	declare @IsInternal int
	SELECT @IsInternal=InternalEmployee FROM Employees WHERE AccountID=@AccID
	
	if(@WorkedHoursMon IS NULL) begin
		SELECT @WorkedHoursMon=0
	end

	if(@ActivityTypeMon IS NULL) begin
		SELECT @ActivityTypeMon=' '
	end

	if(@CommentsMon IS NULL) begin
		SELECT @CommentsMon='Geen commentaar'
	end

	if(@SickMon IS NULL) begin
		SELECT @SickMon=0
	end
	
	if(@HomeMon IS NULL) begin
		SELECT @HomeMon=0
	end

	if(@ApprovedMon IS NULL) begin
		SELECT @ApprovedMon=0
	end

	if(@WorkedHoursTue IS NULL) begin
		SELECT @WorkedHoursTue=0
	end

	if(@ActivityTypeTue IS NULL) begin
		SELECT @ActivityTypeTue=' '
	end

	if(@CommentsTue IS NULL) begin
		SELECT @CommentsTue='Geen commentaar'
	end

	if(@SickTue IS NULL) begin
		SELECT @SickTue=0
	end
	
	if(@HomeTue IS NULL) begin
		SELECT @HomeTue=0
	end

	if(@ApprovedTue IS NULL) begin
		SELECT @ApprovedTue=0
	end
	
	if(@WorkedHoursWed IS NULL) begin
		SELECT @WorkedHoursWed=0
	end

	if(@ActivityTypeWed IS NULL) begin
		SELECT @ActivityTypeWed=' '
	end

	if(@CommentsWed IS NULL) begin
		SELECT @CommentsWed='Geen commentaar'
	end

	if(@SickWed IS NULL) begin
		SELECT @SickWed=0
	end
	
	if(@HomeWed IS NULL) begin
		SELECT @HomeWed=0
	end

	if(@ApprovedWed IS NULL) begin
		SELECT @ApprovedWed=0
	end
	
	if(@WorkedHoursThu IS NULL) begin
		SELECT @WorkedHoursThu=0
	end

	if(@ActivityTypeThu IS NULL) begin
		SELECT @ActivityTypeThu=' '
	end

	if(@CommentsThu IS NULL) begin
		SELECT @CommentsThu='Geen commentaar'
	end

	if(@SickThu IS NULL) begin
		SELECT @SickThu=0
	end
	
	if(@HomeThu IS NULL) begin
		SELECT @HomeThu=0
	end

	if(@ApprovedThu IS NULL) begin
		SELECT @ApprovedThu=0
	end
	
	if(@WorkedHoursFri IS NULL) begin
		SELECT @WorkedHoursFri=0
	end

	if(@ActivityTypeFri IS NULL) begin
		SELECT @ActivityTypeFri=' '
	end

	if(@CommentsFri IS NULL) begin
		SELECT @CommentsFri='Geen commentaar'
	end

	if(@SickFri IS NULL) begin
		SELECT @SickFri=0
	end
	
	if(@HomeFri IS NULL) begin
		SELECT @HomeFri=0
	end

	if(@ApprovedFri IS NULL) begin
		SELECT @ApprovedFri=0
	end

	select @WorkedHoursMon, @ActivityTypeMon, @CommentsMon, @SickMon, @HomeMon, @WorkedHoursTue, @ActivityTypeTue, @CommentsTue, @SickTue, @HomeTue, @WorkedHoursWed, @ActivityTypeWed, @CommentsWed, @SickWed, @HomeWed, @WorkedHoursThu, @ActivityTypeThu, @CommentsThu, @SickThu, @HomeThu, @WorkedHoursFri, @ActivityTypeFri, @CommentsFri, @SickFri, @HomeFri, @ApprovedMon, @ApprovedTue, @ApprovedWed, @ApprovedThu, @ApprovedFri, @IsInternal

END
GO

