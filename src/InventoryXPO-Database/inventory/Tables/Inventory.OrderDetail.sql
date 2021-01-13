CREATE TABLE [Inventory].[OrderDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderId] INT NOT NULL, 
    [ItemId] INT NOT NULL,
    [OrderStatusType] INT NOT NULL DEFAULT 1,
    constraint fk_user_rank foreign key (rank) references [Inventory].[OrderStatusType](id)
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