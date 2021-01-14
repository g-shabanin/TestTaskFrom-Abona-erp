IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[Item]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[Item]
GO
CREATE TABLE [Inventory].[Item]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemName] NCHAR(50) NOT NULL 
)
