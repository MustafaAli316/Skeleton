USE [p2645891]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStock_Delete]
		@ShoesNo = 51

SELECT	@return_value as 'Return Value'

GO
