--EXECUTE CREATE FUNCTION SQL BEFORE THIS ONE
CREATE TABLE ItemInventory
(
	warehouseId		INT		NOT NULL	REFERENCES Warehouse(id),
	itemId			INT		NOT NULL	REFERENCES Item(id),
	quantity		INT				NOT NULL,
	PRIMARY KEY(warehouseId, itemId),
	CONSTRAINT ITEM_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
	CONSTRAINT LIMIT_IQTY	CHECK (quantity >= 0)
);

CREATE TABLE ReturnsInventory
(
	warehouseId		INT		NOT NULL,
	itemId			INT		NOT NULL,
	quantity		INT				NOT NULL,
	PRIMARY KEY(warehouseId, itemId),
	FOREIGN KEY(warehouseId, itemId)
		REFERENCES ItemInventory(warehouseId, itemId)
		ON UPDATE CASCADE,
	CONSTRAINT LIMIT_RQTY	CHECK (quantity >= 0)
);

CREATE TABLE Invoice
(
	invoiceNo	VARCHAR(8)	NOT NULL	PRIMARY KEY,
	orderDate	DATE		NOT NULL,
	clientId	INT			NOT NULL	REFERENCES Client(id)
		ON UPDATE CASCADE
);

CREATE TABLE InvoiceItem
(
	invoiceNo	VARCHAR(8)	NOT NULL
		REFERENCES Invoice(invoiceNo)
		ON UPDATE CASCADE,
	itemId		INT	NOT NULL
		REFERENCES Item(id)
		ON UPDATE CASCADE,
	quantity	INT			NOT NULL,
	orderStatus	VARCHAR(16) NOT NULL,
	PRIMARY KEY(invoiceNo, itemId),
	CONSTRAINT	VALUES_IORDERSTAT CHECK (orderStatus IN ('PENDING', 'SERVED', 'CANCELLED')),
	CONSTRAINT	ITEM_ORDERED_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
	CONSTRAINT	LIMIT_OQTY	CHECK (quantity > 0)
);

CREATE TABLE InventoryMovement
(
	refno		INT			IDENTITY(420160, 1)	PRIMARY KEY,
	movDate		DATETIME	NOT NULL	DEFAULT GETDATE(),
	warehouseId	INT	NOT NULL,
	itemId		INT	NOT NULL,
	quantity	INT			NOT NULL,
	FOREIGN KEY(warehouseId, itemId)
		REFERENCES ItemInventory(warehouseId, itemId),
	FOREIGN KEY(warehouseId, itemId)
		REFERENCES ReturnsInventory(warehouseId, itemId),
	CONSTRAINT LIMIT_IA CHECK(quantity = 0)
);

CREATE TABLE ItemServed
(
	invoiceNo	VARCHAR(8)	NOT NULL,
	itemId		INT			NOT NULL,
	warehouseId	INT			NOT NULL,
	quantity	INT			NOT NULL,
	serveDate	DATE		NOT NULL,
	PRIMARY KEY(invoiceNo, itemId),
	FOREIGN KEY(invoiceNo, itemId)
		REFERENCES InvoiceItem(invoiceNo, itemId)
		ON UPDATE CASCADE,
	FOREIGN KEY(warehouseId, itemId)
		REFERENCES ItemInventory(warehouseId, itemId)
		ON UPDATE CASCADE,
	CONSTRAINT LIMIT_SI
		CHECK (quantity > 0 AND
				 quantity <= dbo.GetOrderedQuantity(invoiceNo, itemId) AND
				 quantity <= dbo.GetItemQuantity(warehouseId, itemId)),
	CONSTRAINT SI_DATE
		CHECK (serveDate > dbo.GetOrderDate(invoiceNo)),
	CONSTRAINT SI_ORDERSTAT
		CHECK (dbo.GetOrderStatus(invoiceNo, itemId) = 'PENDING')
);

CREATE TABLE ItemReturned
(
	refno		INT			IDENTITY(520160, 1)	PRIMARY KEY,
	invoiceNo	VARCHAR(8)	NOT NULL,
	itemId		INT			NOT NULL,
	warehouseId	INT			NOT NULL,
	quantity	INT			NOT NULL,
	returnDate	DATE		NOT NULL,
	FOREIGN KEY(invoiceNo, itemId)
		REFERENCES ItemServed(invoiceNo, itemId),
	FOREIGN KEY(warehouseId, itemId)
		REFERENCES ItemInventory(warehouseId, itemId)
		ON UPDATE CASCADE,
	CONSTRAINT IR_ORDER_STATUS
		CHECK (dbo.GetOrderStatus(invoiceNo, itemId) = 'SERVED'),
	CONSTRAINT LIMIT_RI
		CHECK (quantity>(0) AND dbo.GetOrderedQuantity(invoiceNo,itemId) < dbo.GetReturnedQuantity(invoiceNo,itemId)),
	CONSTRAINT RI_DATE
		CHECK (returnDate > dbo.GetOrderDate(invoiceNo))
);

CREATE TABLE ReturnServed
(
	invoiceNo	VARCHAR(8)	NOT NULL,
	warehouseId	INT			NOT NULL,
	itemId		INT			NOT NULL,
	quantity	INT			NOT NULL,
	serveDate	DATE		NOT NULL,
	PRIMARY KEY(invoiceNo, itemId),
	FOREIGN KEY(invoiceNo, itemId)
		REFERENCES InvoiceItem(invoiceNo, itemId)
		ON UPDATE CASCADE,
	FOREIGN KEY(warehouseId, itemId)
		REFERENCES ReturnsInventory(warehouseId, itemId)
		ON UPDATE CASCADE,
	CONSTRAINT	LIMIT_SR
		CHECK (quantity > 0 AND
				 quantity <= dbo.GetOrderedQuantity(invoiceNo, itemId) AND
				 quantity <= dbo.GetRetItemQuantity(warehouseId, itemId)),
	CONSTRAINT SR_DATE
		CHECK (serveDate > dbo.GetOrderDate(invoiceNo)),
	CONSTRAINT SR_ORDERSTAT
		CHECK (dbo.GetOrderStatus(invoiceNo, itemId) = 'PENDING')
);
