IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[Customer]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[Customer]
GO
CREATE TABLE [Inventory].[Customer]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(40) NOT NULL, 
    [LastName] NCHAR(40) NULL 
)
