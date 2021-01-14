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
USE [Inventory]
GO
INSERT INTO [Inventory].[OrderStatusType] (StatusType)
VALUES
  ('New'),
  ('In Processing'),
  ('Paid'),
  ('Completed');
GO
INSERT INTO [Inventory].[ProductItem] (ItemName, ItemPrice)
VALUES
  ('Product 01', 100.01),
  ('Product 02', 200.02),
  ('Product 03', 300.03),
  ('Product 04', 400.04);
GO
INSERT INTO [Inventory].[Item] (ItemName)
VALUES
  ('Item 01'),
  ('Item 02'),
  ('Item 03'),
  ('Item 04');
GO
INSERT INTO [Inventory].[ItemInStock] (ItemId, QuantityOnStock)
VALUES
  (1, 1001),
  (2, 2002),
  (3, 3003),
  (4, 4004);

