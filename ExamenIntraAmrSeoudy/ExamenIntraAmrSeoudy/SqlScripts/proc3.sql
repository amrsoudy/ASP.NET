CREATE PROCEDURE [dbo].[GetVilleInfo]
	@ville VARCHAR(50)

AS
Begin
	SELECT * FROM Info WHERE Ville = @ville
End