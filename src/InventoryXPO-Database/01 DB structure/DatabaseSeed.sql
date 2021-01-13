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
INSERT INTO [Inventory].[OrderStatusType] (Id, StatusType)
VALUES
  (1, 'New'),
  (2, 'In Processing'),
  (3, 'Paid'),
  (4, 'Completed');
