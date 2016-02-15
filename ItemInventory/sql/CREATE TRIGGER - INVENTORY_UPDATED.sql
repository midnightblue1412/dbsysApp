CREATE TRIGGER INVENTORY_UPDATED 
ON Inventory
FOR INSERT
AS
DECLARE @warehouseId	VARCHAR(16)
DECLARE @itemId			VARCHAR(32)

SELECT @warehouseId = warehouseId, @itemId = itemId
FROM inserted

INSERT INTO ReturnsInventory
VALUES (@warehouseId, @itemId, 0);