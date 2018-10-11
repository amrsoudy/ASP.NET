CREATE PROCEDURE [dbo].[GetInfo]
	@param1 VARCHAR(50)

AS
BEGIN
	SELECT * from Info where nom = @param1 ORDER BY fraisResturant DESC
END