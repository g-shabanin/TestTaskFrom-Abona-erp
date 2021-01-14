IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[OrderStatusType]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[OrderStatusType]
GO
CREATE TABLE [Inventory].[OrderStatusType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[StatusType] VARCHAR(20) NOT NULL UNIQUE 
)
