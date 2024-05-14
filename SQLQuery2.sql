USE [p2645891]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_SelectAll]

SELECT	@return_value as 'Return Value'

GO
