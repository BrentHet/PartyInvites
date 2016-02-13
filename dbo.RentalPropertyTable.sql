CREATE TABLE [dbo].[Table]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [ShortDescription] NVARCHAR(500) NULL, 
    [AddressID] INT NOT NULL, 
    [YearBuilt] INT NOT NULL DEFAULT 2000, 
    [MonthlyHOAFee] MONEY NULL
)
