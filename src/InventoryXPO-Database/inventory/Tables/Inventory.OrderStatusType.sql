IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Inventory].[OrderStatusType]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Inventory].[OrderStatusType]
GO
CREATE TABLE [Inventory].[OrderStatusType]
(
	[Id] INTEGER NOT NULL , -- no identity, so you can control the values
	[StatusType] VARCHAR(20) NOT NULL UNIQUE 
)
