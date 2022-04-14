USE [ATM]
GO

/****** Object:  StoredProcedure [dbo].[Card_GetByCitizenID_and_Pin]    Script Date: 4/14/2022 4:31:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Card_GetByCitizenID_and_Pin] 
	@CitizenshipID varchar(20), @Pin int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM Cards
	INNER JOIN People ON Cards.Pin = @Pin AND People.CitizenshipID = @CitizenshipID AND Cards.PersonID = People.PersonID
END
GO


