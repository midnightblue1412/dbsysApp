CREATE FUNCTION GetOrderDate(@invoiceNo VARCHAR(8))
RETURNS DATE
AS
BEGIN
	DECLARE @date DATE

	SELECT @date = orderDate FROM Invoice
	WHERE invoiceNo = @invoiceNo

	RETURN @date
END;