CREATE FUNCTION GetOrderStatus(@invoiceNo VARCHAR(8), @itemId INT)
RETURNS VARCHAR(16)
AS
BEGIN
	DECLARE @stat VARCHAR(16)

	SELECT @stat = orderStatus FROM InvoiceItem
	WHERE itemId = @itemId AND invoiceNo = @invoiceNo

	RETURN @stat
END;
