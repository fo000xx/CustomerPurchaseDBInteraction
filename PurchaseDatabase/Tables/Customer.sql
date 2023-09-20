CREATE TABLE[dbo].[Customer]
(
    [lCustomerID] INT NOT NULL PRIMARY KEY Identity,
    [szFirstName] NVARCHAR(50) NOT NULL,
    [szLastName] NVARCHAR(50) NOT NULL,
    [szEmail] NVARCHAR(50) NOT NULL,
)