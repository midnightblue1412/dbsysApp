CREATE VIEW InventoryUI
AS
SELECT warehouseId, I.id, I.itemName, quantity
FROM ItemInventory Inv JOIN Item I
ON Inv.itemId = I.id;