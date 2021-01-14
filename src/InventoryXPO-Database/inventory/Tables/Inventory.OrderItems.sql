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
