CREATE TRIGGER RETURN_SERVED
ON ItemServed
FOR INSERT
AS
--SUBTRACT FROM INVENTORY
MERGE INTO ReturnsInventory inv
USING inserted ins
ON inv.warehouseId = ins.warehouseId AND inv.itemId = ins.itemId
WHEN MATCHED THEN
UPDATE SET inv.quantity = inv.quantity - ins.quantity;
--MARK INVOICE AS SERVED
MERGE INTO InvoiceItem inv
USING inserted ins
ON inv.invoiceNo = ins.invoiceNo AND inv.itemId = ins.itemId
WHEN MATCHED THEN
UPDATE SET orderStatus = 'SERVED';
