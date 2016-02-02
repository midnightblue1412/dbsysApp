CREATE FUNCTION GetOrderDate(@itemId VARCHAR(32))
RETURNS DATE
AS
BEGIN
	DECLARE @date DATE

	SELECT @date = orderDate FROM OrderSet
	WHERE id = @itemId

	RETURN @date
END;