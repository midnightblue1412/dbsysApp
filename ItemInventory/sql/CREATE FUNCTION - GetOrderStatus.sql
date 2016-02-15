CREATE FUNCTION GetOrderStatus(@invoiceNo VARCHAR(8), @itemId VARCHAR(32))
RETURNS VARCHAR(2)
AS
BEGIN
	DECLARE @stat VARCHAR(2)

	SELECT @stat = orderStatus FROM InvoiceItem
	WHERE itemId = @itemId AND invoiceNo = @invoiceNo

	RETURN @stat
END;
