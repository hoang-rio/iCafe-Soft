USE [iCafe]
GO

/****** Object:  Table [dbo].[iCafe_OverTime]    Script Date: 10/05/2015 8:43:05 SA ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[iCafe_OverTime](
	[EmployID] [uniqueidentifier] NULL,
	[Month] [numeric](2, 0) NULL,
	[Year] [numeric](4, 0) NULL,
	[NumOverTime] [numeric](18, 0) NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[iCafe_OverTime]  WITH CHECK ADD  CONSTRAINT [FK_iCafe_OverTime_iCafe_Employee] FOREIGN KEY([EmployID])
REFERENCES [dbo].[iCafe_Employee] ([EmployID])
GO

ALTER TABLE [dbo].[iCafe_OverTime] CHECK CONSTRAINT [FK_iCafe_OverTime_iCafe_Employee]
GO


