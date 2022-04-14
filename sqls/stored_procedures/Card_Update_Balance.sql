USE [ATM]
GO

/****** Object:  StoredProcedure [dbo].[Card_Update_Balance]    Script Date: 4/14/2022 4:33:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Card_Update_Balance]
	@Balance money,@id int
AS
BEGIN
	
	SET NOCOUNT ON;

    UPDATE Cards
	SET Balance = @Balance
	WHERE id = @id
END
GO


