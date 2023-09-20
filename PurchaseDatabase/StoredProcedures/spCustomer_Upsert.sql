CREATE PROCEDURE [dbo].[spCustomer_Upsert]
	@CustomerID int output,
	@szFirstName nvarchar(50),
	@szLastName nvarchar(50),
	@szEmail nvarchar(50)

AS
begin

	if exists (select 1 from Customer where szEmail = @szEmail)
	begin
		update Customer set
			szFirstName = @szFirstName,
			szLastName = @szLastName
		where szEmail = @szEmail;
		select @CustomerID = lCustomerID from Customer where szEmail = @szEmail 
	end
	else
	begin
		insert into Customer (szFirstName, szLastName, szEmail)
		values (@szFirstName, @szLastName, @szEmail);
		select @CustomerID = SCOPE_IDENTITY();
	end

end