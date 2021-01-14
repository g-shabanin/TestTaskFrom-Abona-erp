IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[ProductItem]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [ProductItem]
GO
CREATE TABLE [ProductItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[ItemName] NCHAR(50) NOT NULL, 
	[ItemPrice] FLOAT NOT NULL
)
