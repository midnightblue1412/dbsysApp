CREATE FUNCTION GetPendingQuantity(@invoiceNo VARCHAR(8), @itemId INT)
RETURNS INT
AS
BEGIN
	DECLARE @quantity INT

	SELECT @quantity = dbo.GetOrderedQuantity(@invoiceNo, @itemId) - SUM(isv.quantity)
	FROM InvoiceItem ii
	JOIN ItemServed isv ON ii.invoiceNo = isv.invoiceNo AND ii.itemId = isv.itemId
	WHERE ii.itemId = @itemId AND ii.invoiceNo = @invoiceNo

	RETURN @quantity
END;
