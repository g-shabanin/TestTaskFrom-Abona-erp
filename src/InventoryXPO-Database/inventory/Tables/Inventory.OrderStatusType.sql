IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[OrderStatusType]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [OrderStatusType]
GO
CREATE TABLE [OrderStatusType]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[StatusType] VARCHAR(20) NOT NULL UNIQUE 
)
