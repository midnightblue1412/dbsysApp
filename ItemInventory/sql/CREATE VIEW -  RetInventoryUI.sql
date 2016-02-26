CREATE VIEW RetInventoryUI
AS
SELECT I.id, I.itemName, quantity
FROM ReturnsInventory Inv JOIN Item I
ON Inv.itemId = I.id;