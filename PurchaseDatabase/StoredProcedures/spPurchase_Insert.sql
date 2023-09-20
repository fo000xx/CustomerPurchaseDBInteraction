CREATE PROCEDURE [dbo].[spPurchase_Insert]
	@Item nvarchar(50),
	@Cost money,
	@CustomerID int
AS
begin
	insert into Purchase (lCustomerID, szItem, Cost)
	values(@Item, @Cost, @CustomerID);
end