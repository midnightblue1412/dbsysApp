CREATE TRIGGER INVENTORY_ADD 
ON ItemInventory
FOR INSERT
AS
INSERT INTO ReturnsInventory
SELECT warehouseId, itemId, 0
FROM inserted;
INSERT INTO InventoryMovement(warehouseId, itemId, quantity)
SELECT warehouseId, itemId, quantity
FROM inserted