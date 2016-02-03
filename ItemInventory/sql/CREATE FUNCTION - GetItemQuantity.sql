CREATE FUNCTION GetItemQuantity(@invoiceNo VARCHAR(8), @itemId VARCHAR(32))
RETURNS INT
AS
BEGIN
	DECLARE @quantity INT

	SELECT @quantity = quantity FROM ItemOrder
	WHERE id = @itemId AND invoiceNo = @invoiceNo

	RETURN @quantity
END;
