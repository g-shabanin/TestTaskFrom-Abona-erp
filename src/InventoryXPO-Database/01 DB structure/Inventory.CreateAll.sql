-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Customer]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Customer]
GO
CREATE TABLE [Customer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[FirstName] NCHAR(40) NOT NULL, 
	[LastName] NCHAR(40) NULL 
)
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[OrderStatusType]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [OrderStatusType]
GO
CREATE TABLE [OrderStatusType]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[StatusType] VARCHAR(20) NOT NULL UNIQUE 
)
GO
INSERT INTO [OrderStatusType] (Id, StatusType)
VALUES
	(1, 'New'),
	(2, 'In Processing'),
	(3, 'Paid'),
	(4, 'Completed');
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[ProductItem]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [ProductItem]
GO
CREATE TABLE [ProductItem]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[ItemName] NCHAR(50) NOT NULL, 
	[ItemPrice] FLOAT NOT NULL
)
GO
INSERT INTO [ProductItem] (Id, ItemName, ItemPrice)
VALUES
	(1, 'Product 01', 100.01),
	(2, 'Product 02', 200.02),
	(3, 'Product 03', 300.03),
	(4, 'Product 04', 400.04);
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Order]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Order]
GO
CREATE TABLE [Order]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CustomerId] INT NOT NULL,
	[OrderDate] DATETIME NOT NULL, 
	[OrderNum] VARCHAR(50) NOT NULL, 
	[OrderStatus] INT NOT NULL, 
	CONSTRAINT [FK_Order_Customer] FOREIGN KEY (CustomerId)  REFERENCES [Customer] (Id),
	CONSTRAINT [FK_Order_OrderStatusType] FOREIGN KEY (OrderStatus)  REFERENCES [OrderStatusType] (Id),
)
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[OrderItems]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [OrderItems]
GO
CREATE TABLE [OrderItems]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[OrderId] INT NOT NULL, 
	[ProductItemId] INT NOT NULL, 
	CONSTRAINT [FK_OrderItems_Order] FOREIGN KEY ([OrderId]) REFERENCES [Order]([Id]), 
	CONSTRAINT [FK_OrderItems_ProductItem] FOREIGN KEY ([ProductItemId]) REFERENCES [productItem]([Id])
)
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Item]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Item]
GO
CREATE TABLE [Item]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[ItemName] NCHAR(50) NOT NULL 
)
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[ItemInStock]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [ItemInStock]
GO
CREATE TABLE [ItemInStock]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[ItemId] INT NOT NULL,
	[QuantityOnStock] INT NOT NULL DEFAULT 0,
	CONSTRAINT [FK_ItemInStock_Item] FOREIGN KEY ([ItemId]) REFERENCES [Item]([Id])
)
GO
-------------------------
