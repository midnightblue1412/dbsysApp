﻿CREATE TABLE Item
(
	id			VARCHAR(32)		PRIMARY KEY,
	itemName	VARCHAR(64)		NOT NULL,
	itemDesc	VARCHAR(128)	NOT NULL,
	itemStatus	VARCHAR(2)		NOT NULL,
	CONSTRAINT	VALUES_ITEMSTAT	CHECK (itemStatus IN ('AV', 'NA', 'av', 'na'))
);

CREATE TABLE Client
(
	id				VARCHAR(32)		PRIMARY KEY,
	clientName		VARCHAR(64)		UNIQUE			NOT NULL,
	contactNumber	VARCHAR(32)		NOT NULL
);

CREATE TABLE Warehouse
(
	id				VARCHAR(16)		PRIMARY KEY,
	warehouseName	VARCHAR(64)		UNIQUE			NOT NULL,
	warehouseDesc	VARCHAR(128)	NOT NULL,
	warehouseStatus	VARCHAR(2)		NOT NULL,
	CONSTRAINT	VALUES_WAREHOUSESTAT	CHECK (warehouseStatus in ('OP', 'CL', 'op', 'cl'))
);