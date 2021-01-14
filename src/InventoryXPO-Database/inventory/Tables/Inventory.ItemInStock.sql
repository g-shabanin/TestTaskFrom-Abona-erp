IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[ItemInStock]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[ItemInStock]
GO
CREATE TABLE [Inventory].[ItemInStock]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[ItemId] INT NOT NULL,
    [QuantityOnStock] INT NOT NULL DEFAULT 0,
    CONSTRAINT [FK_ItemInStock_Item] FOREIGN KEY ([ItemId]) REFERENCES [Inventory].[Item]([Id])
)
