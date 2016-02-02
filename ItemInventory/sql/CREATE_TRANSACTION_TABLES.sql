--EXECUTE CREATE FUNCTION SQL BEFORE THIS ONE
CREATE TABLE Inventory
(
	warehouseId		VARCHAR(16)		REFERENCES Warehouse(id),
	itemId			VARCHAR(32)		REFERENCES Item(id),
	quantity		INT				NOT NULL,
	CONSTRAINT PK_INVENTORY PRIMARY KEY(warehouseId, itemId),
	CONSTRAINT ITEM_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
	CONSTRAINT LIMIT_IQTY	CHECK (quantity >= 0)
);

CREATE TABLE ReturnsInventory
(
	warehouseId		VARCHAR(16)		REFERENCES Warehouse(id),
	itemId			VARCHAR(32)		REFERENCES Item(id),
	quantity		INT				NOT NULL,
	CONSTRAINT PK_RINVENTORY PRIMARY KEY(warehouseId, itemId),
	CONSTRAINT RITEM_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
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
	CONSTRAINT	ITEM_ORDERED_STAT	CHECK (dbo.GetItemStatus(itemId) = 'AV'),
	CONSTRAINT	LIMIT_OQTY	CHECK (quantity > 0)
);

CREATE TABLE InventoryChanges
(
	itemId			VARCHAR(32)		REFERENCES Item(id),
	warehouseId		VARCHAR(16)		REFERENCES Warehouse(id),		
	changeDate		DATE,
	increase		INT,
	decrease		INT,
    CONSTRAINT [INV_INC_DEC] CHECK (
		[increase] IS NULL AND [decrease] IS NOT NULL OR
		 [increase] IS NOT NULL AND [decrease] IS NULL)
);

CREATE TABLE ReturnsInventoryChanges
(
	invoiceNo		VARCHAR(8)		REFERENCES OrderSet(invoiceNo),
	itemId			VARCHAR(32)		REFERENCES Item(id),
	warehouseId		VARCHAR(16)		REFERENCES Warehouse(id),		
	changeDate		DATE,
	increase		INT,
	decrease		INT,
	CONSTRAINT DATE_REF CHECK (changeDate > dbo.GetOrderDate(itemId)),
    CONSTRAINT [RET_INC_DEC] CHECK (
		[increase] IS NULL AND [decrease] IS NOT NULL OR 
		[increase] IS NOT NULL AND [decrease] IS NULL)
);
