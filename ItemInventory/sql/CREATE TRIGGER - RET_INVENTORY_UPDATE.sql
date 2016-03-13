CREATE TRIGGER RET_INVENTORY_UPDATE
ON ReturnsInventory
FOR UPDATE
AS
IF(UPDATE(quantity))
INSERT INTO InventoryMovement(warehouseId, itemId, quantity)
SELECT ins.warehouseId, ins.itemId, ins.quantity - del.quantity
FROM inserted ins join deleted del
ON ins.warehouseId = del.warehouseId AND ins.itemId = del.itemId;