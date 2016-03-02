CREATE TRIGGER INVENTORY_UPDATE
ON ItemInventory
FOR UPDATE
AS
IF(UPDATE(quantity))
INSERT INTO InventoryMovement(warehouseId, itemId, quantity)
SELECT ins.warehouseId, ins.itemId, ins.quantity - del.quantity
FROM inserted ins join deleted del
ON ins.warehouseId = del.warehouseId AND ins.itemId = del.itemId;