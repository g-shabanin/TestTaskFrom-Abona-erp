CREATE TABLE [Inventory].[OrderDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderId] INT NOT NULL, 
    [ItemId] INT NOT NULL,
    [OrderStatusType] INT NOT NULL DEFAULT 1,
    [OrderDetailQuantity] INT NOT NULL DEFAULT 0,
    [OrderDetailPrice] FLOAT NOT NULL  DEFAULT 0.0,
    CONSTRAINT [FK_OrderItems_Order] FOREIGN KEY ([OrderId]) REFERENCES [Inventory].[Order]([Id]), 
    CONSTRAINT [FK_OrderItems_ProductItem] FOREIGN KEY ([ItemId]) REFERENCES [Inventory].[productItem]([Id])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'OrderDetail',
    @level0type = N'SCHEMA',
    @level0name = N'Invetory',
    @level1type = N'TABLE',
    @level1name = N'OrderDetail',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Link to Items',
    @level0type = N'SCHEMA',
    @level0name = N'Invetory',
    @level1type = N'TABLE',
    @level1name = N'OrderDetail',
    @level2type = N'COLUMN',
    @level2name = N'ItemId'