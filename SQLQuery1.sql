USE [H:\DOCUMENTS\IMAT1604\KARTIK.17\KARTIK.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblAvailability_Sold]
		@RegYear = LC17SZN

SELECT	@return_value as 'Return Value'

GO
