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

	declare @Id_Empleado int = IDENT_CURRENT('Producto')

	INSERT INTO Precio(fk_Producto,Precio, Descuento)
		VALUES(@Id_Empleado,@Precio,@Descuento)

	INSERT INTO DatosPrecio(fk_Producto,Nombre, Descripcion)
		VALUES(@Id_Empleado,@Nombre,@Descripcion)
	END
	IF @@ERROR = 0
		COMMIT
	ELSE
		ROLLBACK
END
EXEC sp_Producto 'Insert',a,NULL,20.5,10,'platanito','Ta Amarillo'