CREATE FUNCTION GetRetItemQuantity(@itemId INT, @warehouseId INT)
RETURNS INT
AS
BEGIN
	DECLARE @quantity INT

	SELECT @quantity = quantity FROM ReturnsInventory
	WHERE itemId = @itemId AND warehouseId = @warehouseId

	RETURN @quantity
END;
