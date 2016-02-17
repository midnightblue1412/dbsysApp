CREATE FUNCTION GetItemQuantity(@warehouseId VARCHAR(16), @itemId VARCHAR(32))
RETURNS INT
AS
BEGIN
	DECLARE @quantity INT

	SELECT @quantity = quantity FROM ItemInventory
	WHERE itemId = @itemId AND warehouseId = @warehouseId

	RETURN @quantity
END;
