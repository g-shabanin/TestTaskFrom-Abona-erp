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
