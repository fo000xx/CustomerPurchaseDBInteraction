CREATE TABLE[dbo].[Purchases]
(
    [lPurchaseID] INT NOT NULL PRIMARY KEY Identity,
    [lCustomerID] INT NOT NULL,
    [szItem] NVARCHAR(50) NOT NULL,
    [Cost] MONEY NOT NULL
)