USE [ATM]
GO

/****** Object:  StoredProcedure [dbo].[People_GetByID]    Script Date: 4/14/2022 4:33:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[People_GetByID] 
	@PersonID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.People 
	WHERE PersonID = @PersonID
END
GO


