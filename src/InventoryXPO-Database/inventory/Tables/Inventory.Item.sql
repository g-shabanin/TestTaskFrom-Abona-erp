IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Item]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Item]
GO
CREATE TABLE [Item]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[ItemName] NCHAR(50) NOT NULL 
)
