IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[ProductItem]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[ProductItem]
GO
CREATE TABLE [Inventory].[ProductItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemName] NCHAR(50) NOT NULL, 
    [ItemPrice] FLOAT NOT NULL
)
