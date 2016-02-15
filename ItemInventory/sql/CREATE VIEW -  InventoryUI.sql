CREATE VIEW InventoryUI
AS
SELECT I.id, I.itemName, quantity
FROM Inventory Inv JOIN Item I
ON Inv.itemId = I.itemId;