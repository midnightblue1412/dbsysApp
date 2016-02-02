--EXECUTE CREATE FUNCTION SQL BEFORE THIS ONE
CREATE TABLE Inventory
(
	warehouseId		VARCHAR(16)		REFERENCES Warehouse(id),
	itemId			VARCHAR(32)		REFERENCES Item(id),
	quantity		INT				NOT NULL,
	CONSTRAINT PK_INVENTORY PRIMARY KEY(warehouseId, itemId),
	CONSTRAINT ITEM_STAT	CHECK (GetItemStatus(itemId) = 'AV'),
	CONSTRAINT LIMIT_IQTY	CHECK (quantity >= 0)
);

CREATE TABLE ReturnsInventory
(
	warehouseId		VARCHAR(16)		REFERENCES Warehouse(id),
	itemId			VARCHAR(32)		REFERENCES Item(id),
	quantity		INT				NOT NULL,
	CONSTRAINT PK_RINVENTORY PRIMARY KEY(warehouseId, itemId),
	CONSTRAINT ITEM_STAT	CHECK (GetItemStatus(itemId) = 'AV'),
	CONSTRAINT LIMIT_RQTY	CHECK (quantity >= 0)
);

CREATE TABLE OrderSet
(
	invoiceNo	VARCHAR(8)	PRIMARY KEY		NOT NULL,
	orderDate	DATE		NOT NULL,
	clientId	VARCHAR(32)	NOT NULL		REFERENCES Client(id)
);

CREATE TABLE ItemOrder
(
	invoiceNo	VARCHAR(8)	REFERENCES OrderSet(invoiceNo),
	itemId		VARCHAR(32)	NOT NULL	REFERENCES Item(id),
	quantity	INT			NOT NULL,
	orderStatus	VARCHAR(16) NOT NULL,
	CONSTRAINT	VALUES_IORDERSTAT CHECK (orderStatus IN ('PENDING', 'SERVED', 'CANCELLED')),
	CONSTRAINT	ITEM_ORDERED_STAT	CHECK (GetItemStatus(itemId) = 'AV'),
	CONSTRAINT	LIMIT_OQTY	CHECK (quantity > 0)
);

CREATE TABLE InventoryChanges
(
	itemId			VARCHAR(32)		REFERENCES Item(itemId),
	warehouseId		VARCHAR(16)		REFERENCES Warehouse(warehouseId),		
	changeDate		DATE,
	increase		INT,
	decrease		INT
);

CREATE TABLE ReturnsInventoryChanges
(
	invoiceNo		VARCHAR(8)		REFERENCES OrderSet(invoiceNo),
	itemId			VARCHAR(32)		REFERENCES Item(itemId),
	warehouseId		VARCHAR(16)		REFERENCES Warehouse(warehouseId),		
	changeDate		DATE,
	increase		INT,
	decrease		INT,
	CONSTRAINT DATE_REF CHECK (changeDate < GetOrderDate(itemId))
);
