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
-- Author:		<Hoàng>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_SALARY_PERMONTH
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT iCafe_Employee.EmployID,Fullname,iCafe_Permission.SalaryValue+iCafe_Permission.SalaryOverTime*NumOvertime As [Salary],convert(varchar,MONTH(GETDATE()),103)+'/'+convert(varchar,YEAR(GETDATE()),103) as [SalryOfMonth]
from iCafe_Employee,iCafe_Bonus_Punish,iCafe_Permission
Where iCafe_Employee.EmployID=iCafe_Bonus_Punish.EmployID
and iCafe_Employee.PerID=iCafe_Permission.PerID
GROUP BY Fullname,iCafe_Permission.SalaryValue,iCafe_Permission.SalaryOverTime,NumOvertime,iCafe_Employee.EmployID
END
GO
