
--Sample Store Procedure
--exec MasterOrderinsertupdatedelete @StatementType = 'select', @orderId = 25

--Database : MyShop
--select * from Orders
--select * from OrderDetails

CREATE PROCEDURE pr_order_insertupdatedelete 
(
	@orderId INTEGER = NULL,
	@readableOrderId VARCHAR(50) = NULL,
	@customerId INTEGER = NULL,
	@deliveryAddress DECIMAL(10, 2) = NULL,
	@phoneNumber VARCHAR(20) = NULL,
	@paymentMethod NVARCHAR(20) = NULL,
	@bkashNumber NVARCHAR(20) = NULL,
	@amountTotal DECIMAL = NULL,
	@discount DECIMAL = NULL,
	@shippingCost DECIMAL = NULL,
	@grandTotal DECIMAL = NULL,
	@invoiceStatusId INTEGER = NULL,
	@status bit = 1,
	@StatementType NVARCHAR(20)  = NULL
)

AS
  BEGIN

      IF @StatementType = 'Insert'
        BEGIN
            INSERT INTO Orders
						([Key], OrderReadableId, CustomerId, DeliveryAddress, PhoneNumber, PaymentMethod, BkashNumber, AmountTotal, Discount, 
						 ShippingCost, GrandTotal, InvoiceStatusId, CreatedAt, UpdatedAt, CreatedBy, UpdatedBy, Status, IsDelete)
            
			VALUES      (NEWID(), @readableOrderId, @customerId, @deliveryAddress, @phoneNumber, @paymentMethod, @bkashNumber, @amountTotal, @discount, 
						 @shippingCost, @grandTotal, @invoiceStatusId, GETDATE(), GETDATE(), 0, 0, 1, 0)
        END

      IF @StatementType = 'Select'
		BEGIN
            SELECT * FROM  Orders WHERE (@orderId IS NULL OR OrderId = @orderId)     
			SELECT * FROM  OrderDetails WHERE (@orderId IS NULL OR OrderId = @orderId)   
        END

      IF @StatementType = 'Update'
        BEGIN
            UPDATE Orders
            SET    DeliveryAddress = @deliveryAddress,
                   PhoneNumber = @phoneNumber,
                   InvoiceStatusId = @invoiceStatusId,
                   Status = @status
            WHERE  OrderId = @orderId
        END

      ELSE IF @StatementType = 'Delete'
        BEGIN
            DELETE FROM Orders WHERE  @orderId = @orderId
			DELETE FROM OrderDetails WHERE  @orderId = @orderId
        END
  END