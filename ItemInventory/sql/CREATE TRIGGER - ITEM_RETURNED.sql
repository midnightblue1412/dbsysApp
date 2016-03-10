CREATE TRIGGER ITEM_RETURNED
ON ItemReturned
FOR INSERT
AS
--ADD ITEMS TO RETURNS INVENTORY
MERGE INTO ReturnsInventory ret
USING inserted ins
ON ret.warehouseId = ins.warehouseId AND ret.itemId = ins.itemId
WHEN MATCHED THEN
UPDATE SET ret.quantity = ret.quantity + ins.quantity;
