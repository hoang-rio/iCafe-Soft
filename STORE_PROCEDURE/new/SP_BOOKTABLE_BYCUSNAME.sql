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
CREATE PROCEDURE SP_BOOKTABLE_BYCUSNAME
	@CusName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT BTableID,CusName,CusPhone,ZoneName,BookTime,EndTime,NumPeople,TableName,Deposit,iCafe_BookTable.Descript,[Status] 
	from iCafe_Customer,iCafe_Table,iCafe_Zone,iCafe_BookTable
	where iCafe_Customer.CusID=iCafe_BookTable.CusID
	and iCafe_Table.TableID=iCafe_BookTable.TableID
	and iCafe_Zone.ZoneID=iCafe_BookTable.ZoneID
	and iCafe_Customer.CusName like '%'+@CusName+'%'
	and	Status!=1
END
GO
