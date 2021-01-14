IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Customer]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Customer]
GO
CREATE TABLE [Customer]
(
    [Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(40) NOT NULL, 
    [LastName] NCHAR(40) NULL 
)
