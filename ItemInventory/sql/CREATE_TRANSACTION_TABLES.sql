--EXECUTE CREATE FUNCTION SQL BEFORE THIS ONE
CREATE TABLE Inventory
(
	warehouseId		VARCHAR(16)		NOT NULL	REFERENCES Warehouse(id),
	itemId			VARCHAR(32)		NOT NULL	REFERENCES Item(id),
	quantity		INT				NOT NULL,
	INDEX warehouseId (warehouseId),
	CONSTRAINT PK_INVENTORY PRIMARY KEY(warehouseId, itemId),
	CONSTRAINT ITEM_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
	CONSTRAINT LIMIT_IQTY	CHECK (quantity >= 0)
);

CREATE TABLE ReturnsInventory
(
	warehouseId		VARCHAR(16)		NOT NULL	REFERENCES Warehouse(id),
	itemId			VARCHAR(32)		NOT NULL	REFERENCES Item(id),
	quantity		INT				NOT NULL,
	INDEX warehouseId (warehouseId),
	CONSTRAINT PK_RINVENTORY PRIMARY KEY(warehouseId, itemId),
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

CREATE TABLE OrderSet
(
	invoiceNo	VARCHAR(8)	NOT NULL	PRIMARY KEY,
	orderDate	DATE		NOT NULL,
	clientId	VARCHAR(32)	NOT NULL	REFERENCES Client(id)
);

CREATE TABLE ItemOrder
(
	invoiceNo	VARCHAR(8)	NOT NULL	REFERENCES OrderSet(invoiceNo),
	itemId		VARCHAR(32)	NOT NULL	REFERENCES Item(id),
	quantity	INT			NOT NULL,
	orderStatus	VARCHAR(16) NOT NULL,
	CONSTRAINT	VALUES_IORDERSTAT CHECK (orderStatus IN ('PENDING', 'SERVED', 'CANCELLED')),
	CONSTRAINT	ITEM_ORDERED_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
	CONSTRAINT	LIMIT_OQTY	CHECK (quantity > 0)
);

CREATE TABLE ServedItem
(
	invoiceNo	VARCHAR(8)	NOT NULL	REFERENCES OrderSet(invoiceNo),
	itemId		VARCHAR(32)	NOT NULL	REFERENCES Item(id),
	warehouseId	VARCHAR(16)	NOT NULL	REFERENCES Warehouse(id),
	quantity	INT			NOT NULL,
	serveDate	DATE		NOT NULL,
	PRIMARY KEY(invoiceNo, itemId)
);

CREATE TABLE ReturnedItem
(
	invoiceNo	VARCHAR(8)	NOT NULL	REFERENCES OrderSet(invoiceNo),
	itemId		VARCHAR(32)	NOT NULL	REFERENCES Item(id),
	warehouseId	VARCHAR(16)	NOT NULL	REFERENCES Warehouse(id),
	quantity	INT			NOT NULL,
	returnDate	DATE		NOT NULL,
	PRIMARY KEY(invoiceNo, itemId),
	CONSTRAINT LIMIT_RI
		CHECK (quantity > 0 AND quantity <= dbo.GetItemQuantity(itemId, invoiceNo))
);

CREATE TABLE ServedReturn
(
	itemId		VARCHAR(32)	NOT NULL,
	warehouseId	VARCHAR(16)	NOT NULL,
	quantity	INT			NOT NULL,
	serveDate	DATE		NOT NULL,
	FOREIGN KEY(warehouseId, itemId) REFERENCES ReturnsInventory(warehouseId, itemId),
	CONSTRAINT	LIMIT_SR
		CHECK	(quantity <= dbo.GetRetInventoryQty(itemId, warehouseId))
);
