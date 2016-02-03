CREATE FUNCTION GetRetItemQuantity(@itemId VARCHAR(32), @warehouseId VARCHAR(16))
RETURNS INT
AS
BEGIN
	DECLARE @quantity INT

	SELECT @quantity = quantity FROM ReturnsInventory
	WHERE itemId = @itemId AND warehouseId = @warehouseId

	RETURN @quantity
END;
