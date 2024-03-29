USE [iCafe]
GO
/****** Object:  StoredProcedure [dbo].[SP_SALARY_PERMONTH]    Script Date: 10/05/2015 7:06:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Hoàng>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_SALARY_PERMONTH]
@Month varchar(2),
@Year varchar(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT iCafe_Employee.EmployID,PerName,Fullname,iCafe_Permission.SalaryValue As [Salary],@Month+'/'+@Year as [SalaryOfMonth]
from iCafe_Employee,iCafe_Bonus_Punish,iCafe_Permission
Where iCafe_Employee.EmployID=iCafe_Bonus_Punish.EmployID
and iCafe_Employee.PerID=iCafe_Permission.PerID
GROUP BY Fullname,iCafe_Permission.SalaryValue,iCafe_Permission.SalaryOverTime,NumOvertime,iCafe_Employee.EmployID,PerName
END
