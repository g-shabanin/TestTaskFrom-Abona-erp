-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[Customer]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[Customer]
GO
CREATE TABLE [Inventory].[Customer]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(40) NOT NULL, 
    [LastName] NCHAR(40) NULL 
)
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[OrderStatusType]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[OrderStatusType]
GO
CREATE TABLE [Inventory].[OrderStatusType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[StatusType] VARCHAR(20) NOT NULL UNIQUE 
)
GO
INSERT INTO [Inventory].[OrderStatusType] (StatusType)
VALUES
  ('New'),
  ('In Processing'),
  ('Paid'),
  ('Completed');
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[ProductItem]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[ProductItem]
GO
CREATE TABLE [Inventory].[ProductItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemName] NCHAR(50) NOT NULL, 
    [ItemPrice] FLOAT NOT NULL
)
GO
INSERT INTO [Inventory].[ProductItem] (ItemName, ItemPrice)
VALUES
  ('Product 01', 100.01),
  ('Product 02', 200.02),
  ('Product 03', 300.03),
  ('Product 04', 400.04);
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[Order]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[Order]
GO
CREATE TABLE [Inventory].[Order]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [CustomerId] INT NOT NULL,
    [OrderDate] DATETIME NOT NULL, 
    [OrderNum] VARCHAR(50) NOT NULL, 
    [OrderStatus] INT NOT NULL, 
CONSTRAINT [FK_Order_Customer] FOREIGN KEY (CustomerId)  REFERENCES [Inventory].[Customer] (Id),
CONSTRAINT [FK_Order_OrderStatusType] FOREIGN KEY (OrderStatus)  REFERENCES [Inventory].[OrderStatusType] (Id),
)
GO
-------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[OrderItems]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[OrderItems]
GO
CREATE TABLE [Inventory].[OrderItems]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderId] INT NOT NULL, 
    [ProductItemId] INT NOT NULL, 
    CONSTRAINT [FK_OrderItems_Order] FOREIGN KEY ([OrderId]) REFERENCES [Inventory].[Order]([Id]), 
    CONSTRAINT [FK_OrderItems_ProductItem] FOREIGN KEY ([ProductItemId]) REFERENCES [Inventory].[productItem]([Id])
)
GO
-------------------------


