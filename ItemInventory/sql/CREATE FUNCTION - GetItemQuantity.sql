CREATE FUNCTION GetItemQuantity(@warehouseId INT, @itemId INT)
RETURNS INT
AS
BEGIN
	DECLARE @quantity INT

	SELECT @quantity = quantity FROM ItemInventory
	WHERE itemId = @itemId AND warehouseId = @warehouseId

	RETURN @quantity
END;
