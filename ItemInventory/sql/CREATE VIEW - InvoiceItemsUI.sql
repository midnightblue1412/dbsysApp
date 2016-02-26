CREATE VIEW InvoiceItemsUI
AS
SELECT id, itemName, quantity, orderStatus
FROM InvoiceItem INV JOIN Item I
	ON INV.itemId = I.id