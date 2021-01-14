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
