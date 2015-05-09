-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_BONUS_PUNISH_OFEMPLOY
	@Month nvarchar(2),
	@Year nvarchar(4),
	@EmployID uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT SUM(iCafe_Bonus_Punish.Value) As [TotalBonusPunish]
	from iCafe_Bonus_Punish where YEAR(iCafe_Bonus_Punish.Time)=@Year
	and MONTH(iCafe_Bonus_Punish.Time)=@Month
	and EmployID=@EmployID
	GROUP BY iCafe_Bonus_Punish.EmployID
	
END
GO