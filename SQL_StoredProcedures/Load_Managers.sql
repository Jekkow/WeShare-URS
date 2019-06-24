USE [WURS]
GO

/****** Object:  StoredProcedure [dbo].[Load_Managers]    Script Date: 20/06/2019 16:51:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		< Dammer, Jacco>
-- Create date: <11-04-2019>
-- Description:	<Manager opvragen op basis van functie>
-- =============================================

CREATE PROCEDURE [dbo].[Load_Managers]
	-- parameters
	@in_IP nvarchar(16)
AS
BEGIN
	SET NOCOUNT ON;

	declare @Manager nvarchar(64)
	SELECT @Manager=[Function] FROM Employees WHERE [Function]='Manager'

	select FirstName FROM Employees WHERE [Function]=@Manager
	
END
GO

