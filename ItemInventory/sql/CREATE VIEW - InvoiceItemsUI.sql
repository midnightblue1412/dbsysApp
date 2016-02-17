CREATE VIEW InvoiceItemsUI
AS
SELECT id, itemName, quantity, orderStatus
FROM Invoice INV JOIN Item I
	ON INV.itemId = I.id