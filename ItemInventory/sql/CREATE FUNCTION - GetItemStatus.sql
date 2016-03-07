CREATE FUNCTION GetItemStatus(@itemId INT)
RETURNS VARCHAR(2)
AS
BEGIN
	DECLARE @stat VARCHAR(2)

	SELECT @stat = itemStatus FROM Item
	WHERE id = @itemId

	RETURN @stat
END;
