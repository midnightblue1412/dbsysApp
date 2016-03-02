CREATE TRIGGER ITEM_RETURNED
ON ItemReturned
FOR INSERT
AS
UPDATE ReturnsInventory
SET ReturnsInventory.quantity = ins.quantity
FROM
inserted ins
WHERE ReturnsInventory.warehouseId = ins.warehouseId AND ReturnsInventory.itemId = ins.itemId;