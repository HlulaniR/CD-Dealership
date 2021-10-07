CREATE TABLE [dbo].[Sales_Order]
(
	[SalesID] INT NOT NULL PRIMARY KEY, 
    [Quantity] FLOAT NULL, 
    [ProductID] INT NULL, 
    [OrderID] INT NULL, 
    [Status] BIT NULL
)
