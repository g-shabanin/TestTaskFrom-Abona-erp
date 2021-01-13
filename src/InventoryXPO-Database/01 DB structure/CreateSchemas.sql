use InventoryXPO;  
GO  
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'Inventory')
BEGIN
     CREATE SCHEMA Inventory -- optional param AUTHORIZATION dbo 
END
