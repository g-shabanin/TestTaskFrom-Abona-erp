IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[Order]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[Order]
GO
CREATE TABLE [Inventory].[Order]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderDate] DATETIME NOT NULL, 
    [OrderNum] VARCHAR(50) NOT NULL, 
    [OrderStatus] INT NOT NULL, 
    CONSTRAINT [FK_Order_OrderStatusType] FOREIGN KEY ([OrderStatus]) REFERENCES [Inventory].[OrderStatusType]([Id]) 
)
