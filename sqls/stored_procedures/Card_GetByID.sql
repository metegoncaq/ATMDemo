USE [ATM]
GO

/****** Object:  StoredProcedure [dbo].[Card_GetByID]    Script Date: 4/14/2022 4:32:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Card_GetByID] @id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM Cards
	WHERE id = @id
END
GO


