CREATE FUNCTION GetReturnedQuantity(@invoiceNo VARCHAR(8), @itemId INT)
RETURNS INT
AS
BEGIN
	DECLARE @quantity INT

	SELECT @quantity = COALESCE(SUM(quantity), 0) FROM ItemReturned
	WHERE itemId = @itemId AND invoiceNo = @invoiceNo

	RETURN @quantity
END;
