CREATE VIEW InventoryUI
AS
SELECT I.id, I.itemName, quantity
FROM ItemInventory Inv JOIN Item I
ON Inv.itemId = I.id;