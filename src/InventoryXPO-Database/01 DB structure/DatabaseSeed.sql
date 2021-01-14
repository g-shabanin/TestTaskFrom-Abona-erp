/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [OrderStatusType] (Id, StatusType)
VALUES
  (1, 'New'),
  (2, 'In Processing'),
  (3, 'Paid'),
  (4, 'Completed');
GO
INSERT INTO [ProductItem] (Id, ItemName, ItemPrice)
VALUES
  (1, 'Product 01', 100.01),
  (2, 'Product 02', 200.02),
  (3, 'Product 03', 300.03),
  (4, 'Product 04', 400.04);
GO
INSERT INTO [Item] (Id, ItemName)
VALUES
  (1, 'Item 01'),
  (2, 'Item 02'),
  (3, 'Item 03'),
  (4, 'Item 04');
GO
INSERT INTO [ItemInStock] (Id, ItemId, QuantityOnStock)
VALUES
  (1, 1, 1001),
  (2, 2, 2002),
  (3, 3, 3003),
  (4, 4, 4004);

