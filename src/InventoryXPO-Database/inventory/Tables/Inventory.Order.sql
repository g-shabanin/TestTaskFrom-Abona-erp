IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[Order]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [Order]
GO
CREATE TABLE [Order]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CustomerId] INT NOT NULL,
	[OrderDate] DATETIME NOT NULL, 
	[OrderNum] VARCHAR(50) NOT NULL, 
	[OrderStatus] INT NOT NULL, 
	CONSTRAINT [FK_Order_Customer] FOREIGN KEY (CustomerId)  REFERENCES [Customer] (Id),
	CONSTRAINT [FK_Order_OrderStatusType] FOREIGN KEY (OrderStatus)  REFERENCES [OrderStatusType] (Id),
)
