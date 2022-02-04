Use MAD;

Create view SelectAll
as
        SELECT id_Producto
        FROM Producto



DROP PROCEDURE sp_Producto;
alter PROCEDURE sp_Producto(
	@Opc			varchar(20),
	@ID_Producto	int =NULL,
	@fk_Empleado	int =NULL,
	@Precio			float =NULL,
	@Descuento		float =NULL,
	@Nombre			varchar(20)=NULL,
	@Descripcion	varchar(20)=NULL,
	@Categoria		varchar(20)=NULL
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

	INSERT INTO DatosPrecio(fk_Producto,Nombre, Descripcion,Categoria)
		VALUES(@Id_Empleado,@Nombre,@Descripcion,@Categoria)
	END

	IF @Opc = 'Delete'
    BEGIN
        DELETE FROM DatosPrecio WHERE fk_Producto= @ID_Producto
        DELETE FROM Precio WHERE  fk_Producto= @ID_Producto
        DELETE FROM Producto WHERE  id_Producto= @ID_Producto
    END

	IF @Opc = 'CARRITO'
    BEGIN       
		   SELECT Nombre, Descripcion, Categoria
        FROM DatosPrecio
		where fk_Producto=@ID_Producto
    END

	IF @Opc = 'CARRITO2'
    BEGIN
	 SELECT Precio, Descuento
        FROM Precio
		where fk_Producto=@ID_Producto
	    END




	IF @Opc = 'GetID'
    BEGIN 
        SELECT fk_Producto
        FROM DatosPrecio
        WHERE Nombre = @Nombre
    END
	IF @Opc = 'Select'
    BEGIN
        SELECT fk_Producto, Nombre,Descripcion,Categoria FROM DatosPrecio where fk_Producto=@ID_Producto
        
    END


	IF @Opc = 'Selectprecio'
    BEGIN
        SELECT * FROM Precio where fk_Producto=@ID_Producto
        
    END


	IF @Opc = 'Update'
    BEGIN
        UPDATE Producto
            SET fk_Empleados = ISNULL(@fk_Empleado, fk_Empleados) WHERE id_Producto = @ID_Producto;
        UPDATE DatosPrecio
            SET Nombre = ISNULL(@Nombre, Nombre),
                Descripcion = ISNULL(@Descripcion, Descripcion),
                Categoria=ISNULL(@Categoria,Categoria)
                WHERE fk_Producto = @ID_Producto;

        UPDATE  Precio
            SET Precio= ISNULL(@Precio,Precio),
                Descuento=ISNULL(@Descuento,Descuento)
            WHERE fk_Producto = @ID_Producto;
    END
	IF @Opc = 'SearchProducto'
    BEGIN 
        SELECT fk_Producto
        FROM DatosPrecio
        WHERE fk_Producto = @ID_Producto
    END

	IF @Opc = 'SelectAll'
    BEGIN
	select * from SelectAll
    END

		IF @Opc = 'SelectAll2'
    BEGIN
        SELECT Nombre
        FROM DatosPrecio
    END

	

	IF @@ERROR = 0
		COMMIT
	ELSE
		ROLLBACK
END





-----------EJEMPLO---- DATO DE ALTA DE INFORMACION
EXEC sp_Producto 'Insert',Null,21,20.5,10,'platanito','Ta Amarillo','Fruta'


--------CARGAR-----------
EXEC sp_Producto 'Update',6 ,21,20.5,10,'platanito','Ta Amarilo','Fruta'


use MAD
----Deplegar TAblas---
SELECT * From Producto
SELECT * From Precio
SELECT * From DatosPrecio

SElect * from Cuentas

 SELECT fk_Producto FROM DatosPrecio  WHERE Nombre = 'platano'
 