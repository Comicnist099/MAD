Use MAD;
DROP PROCEDURE sp_Producto;
Create PROCEDURE sp_Producto(
	@Opc			varchar(20),
	@ID_Producto	int =NULL,
	@fk_Empleado	int =NULL,
	@Precio			float =NULL,
	@Descuento		float =NULL,
	@Nombre			varchar(20)=NULL,
	@Descripcion	varchar(20)=NULL
)
AS
BEGIN
	BEGIN TRANSACTION

		IF @Opc = 'Insert'
	BEGIN 
	INSERT INTO Producto(fk_Empleados)
		VALUES(@fk_Empleado);

	declare @fk_producto int = IDENT_CURRENT('Producto')

	INSERT INTO Precio(fk_Producto,Precio, Descuento)
		VALUES(@fk_producto,@Precio,@Descuento)

	INSERT INTO DatosPrecio(fk_Producto,Nombre, Descripcion)
		VALUES(@fk_producto,@Nombre,@Descripcion)
	END
	IF @@ERROR = 0
		COMMIT
	ELSE
		ROLLBACK
END
EXEC sp_Producto 'Insert',null,4,20.5,10.0,'platanito','Ta Amarillo'

Select *from Producto
Select *from Precio
Select *from DatosPrecio

drop table Precio
drop table DatosPrecio
drop table Producto
