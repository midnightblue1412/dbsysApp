CREATE TRIGGER ITEM_SERVED
ON ItemServed
FOR INSERT
AS
DECLARE @invoiceNo		VARCHAR(16)
DECLARE @itemId			VARCHAR(32)
DECLARE @warehouseId	VARCHAR(16)
DECLARE @quantity		INT

SELECT @invoiceNo = invoiceNo, @itemId = itemId, @warehouseId = warehouseId
FROM inserted

UPDATE Inventory SET quantity = quantity - @quantity
WHERE warehouseId = @warehouseId AND itemId = @itemId