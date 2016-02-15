--EXECUTE CREATE FUNCTION SQL BEFORE THIS ONE
CREATE TABLE Inventory
(
	warehouseId		VARCHAR(16)		NOT NULL	REFERENCES Warehouse(id),
	itemId			VARCHAR(32)		NOT NULL	REFERENCES Item(id),
	quantity		INT				NOT NULL,
	INDEX warehouseId (warehouseId),
	PRIMARY KEY(warehouseId, itemId),
	CONSTRAINT ITEM_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
	CONSTRAINT LIMIT_IQTY	CHECK (quantity >= 0)
);

CREATE TABLE ReturnsInventory
(
	warehouseId		VARCHAR(16)		NOT NULL	REFERENCES Warehouse(id),
	itemId			VARCHAR(32)		NOT NULL	REFERENCES Item(id),
	quantity		INT				NOT NULL,
	INDEX warehouseId (warehouseId),
	PRIMARY KEY(warehouseId, itemId),
	CONSTRAINT RITEM_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
	CONSTRAINT LIMIT_RQTY	CHECK (quantity >= 0)
);

CREATE TABLE InventoryAddition
(
	referenceNo	INT IDENTITY(1024, 1)	PRIMARY KEY,
	itemId		VARCHAR(32)	NOT NULL	REFERENCES Item(id),
	warehouseNo	VARCHAR(16)	NOT NULL	REFERENCES Warehouse(id),
	quantity	INT			NOT NULL,
	CONSTRAINT LIMIT_IA CHECK(quantity > 0)
);

CREATE TABLE Invoice
(
	invoiceNo	VARCHAR(8)	NOT NULL	PRIMARY KEY,
	orderDate	DATE		NOT NULL,
	clientId	VARCHAR(32)	NOT NULL	REFERENCES Client(id)
);

CREATE TABLE InvoiceItem
(
	invoiceNo	VARCHAR(8)	NOT NULL	REFERENCES Invoice(invoiceNo),
	itemId		VARCHAR(32)	NOT NULL	REFERENCES Item(id),
	quantity	INT			NOT NULL,
	orderStatus	VARCHAR(16) NOT NULL,
	PRIMARY KEY(invoiceNo, itemId),
	CONSTRAINT	VALUES_IORDERSTAT CHECK (orderStatus IN ('PENDING', 'SERVED', 'CANCELLED')),
	CONSTRAINT	ITEM_ORDERED_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
	CONSTRAINT	LIMIT_OQTY	CHECK (quantity > 0)
);

CREATE TABLE ItemServed
(
	invoiceNo	VARCHAR(8)	NOT NULL,
	itemId		VARCHAR(32)	NOT NULL,
	warehouseId	VARCHAR(16)	NOT NULL,
	quantity	INT			NOT NULL,
	serveDate	DATE		NOT NULL,
	PRIMARY KEY(invoiceNo, itemId),
	FOREIGN KEY(invoiceNo, itemId) REFERENCES InvoiceItem(invoiceNo, itemId),
	FOREIGN KEY(warehouseId, itemId) REFERENCES Inventory(warehouseId, itemId),
	CONSTRAINT LIMIT_SI
		CHECK (quantity > 0 AND
				 quantity <= dbo.GetOrderedQuantity(itemId, invoiceNo) AND
				 quantity <= dbo.GetItemQuantity(warehouseId, itemId) AND
				 quantity <= dbo.GetOrderedQuantity(itemId, invoiceNo)),
	CONSTRAINT SI_DATE
		CHECK (serveDate > dbo.GetOrderDate(invoiceNo)),
	CONSTRAINT SI_ORDERSTAT
		CHECK (dbo.GetOrderStatus(invoiceNo, itemId) != 'CANCELLED')
);

CREATE TABLE ItemReturned
(
	invoiceNo	VARCHAR(8)	NOT NULL,
	itemId		VARCHAR(32)	NOT NULL,
	warehouseId	VARCHAR(16)	NOT NULL,
	quantity	INT			NOT NULL,
	returnDate	DATE		NOT NULL,
	PRIMARY KEY(invoiceNo, itemId),
	FOREIGN KEY(invoiceNo, itemId) REFERENCES InvoiceItem(invoiceNo, itemId),
	FOREIGN KEY(warehouseId, itemId) REFERENCES Inventory(warehouseId, itemId),
	CONSTRAINT LIMIT_RI
		CHECK (quantity > 0 AND quantity <= dbo.GetOrderedQuantity(itemId, invoiceNo)),
	CONSTRAINT RI_DATE
		CHECK (returnDate > dbo.GetOrderDate(invoiceNo))
);

CREATE TABLE ReturnServed
(
	invoiceNo	VARCHAR(8)	NOT NULL,
	warehouseId	VARCHAR(16)	NOT NULL,
	itemId		VARCHAR(32)	NOT NULL,
	quantity	INT			NOT NULL,
	serveDate	DATE		NOT NULL,
	PRIMARY KEY(invoiceNo, itemId),
	FOREIGN KEY(invoiceNo, itemId) REFERENCES InvoiceItem(invoiceNo, itemId),
	FOREIGN KEY(warehouseId, itemId) REFERENCES ReturnsInventory(warehouseId, itemId),
	CONSTRAINT	LIMIT_SR
		CHECK (quantity > 0 AND
				 quantity <= dbo.GetOrderedQuantity(itemId, invoiceNo) AND
				 quantity <= dbo.GetRetItemQuantity(warehouseId, itemId)),
	CONSTRAINT SR_DATE
		CHECK (serveDate > dbo.GetOrderDate(invoiceNo)),
	CONSTRAINT SR_ORDERSTAT
		CHECK (dbo.GetOrderStatus(invoiceNo, itemId) != 'CANCELLED')
);
