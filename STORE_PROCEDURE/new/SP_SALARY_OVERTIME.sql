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
CREATE PROCEDURE SP_SALARY_OVERTIME
	@EmployID uniqueidentifier,
	@Month varchar(2),
	@Year varchar(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT iCafe_Permission.SalaryOverTime*iCafe_OverTime.NumOverTime as [SalaryOverTime] from iCafe_Permission,iCafe_Employee,iCafe_OverTime
	where iCafe_Permission.PerID=iCafe_Employee.PerID
	and iCafe_Employee.EmployID=iCafe_OverTime.EmployID
	and iCafe_OverTime.EmployID=@EmployID
	and iCafe_OverTime.Month=@Month
	and iCafe_OverTime.Year=@Year
END
GO
