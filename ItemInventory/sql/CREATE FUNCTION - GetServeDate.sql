CREATE FUNCTION GetServeDate(@invoiceNo VARCHAR(8), @itemId INT)
RETURNS DATE
AS
BEGIN
	DECLARE @date DATE

	SELECT @date = serveDate FROM ItemServed
	WHERE invoiceNo = @invoiceNo AND itemId = @itemId

	RETURN @date
END;