

use MAD
CREATE FUNCTION Operaciones
 (
@Precio float,
@Cantidad float 
)
RETURNS float
begin
declare @Total2 float =@Cantidad*@Precio; 
Return @Total2
end


CREATE FUNCTION PrecioDescuentado
 (
@Precio float,
@Descuento float 
)
RETURNS float
begin
declare @PrecioDescuentado2 float=(@Precio*@Descuento)/100;
Return @PrecioDescuentado2
end

CREATE FUNCTION PrecioDescuentado2
 (
@Precio float,
@descuentoto2 float 
)
RETURNS float
begin
declare @PrecioDescuentado2 float=@Precio-@descuentoto2;
Return @PrecioDescuentado2
end



CREATE FUNCTION Descuentoto2
 (
@Precio float,
@descuentoto2 float 
)
RETURNS float
begin
declare @PrecioDescuentado2 float=(@Precio*@descuentoto2)/100;
Return @PrecioDescuentado2
end


Use MAD;
drop procedure sp_Carrito

alter PROCEDURE sp_Carrito(
	@Opc						VARCHAR(20),
	@Id_Cantidad				INT=NULL,
	@Estado						varchar(20) = 'NOPAGADO',
	@id_Sucursal				int=null,
	@Envio						varchar(20) = 'SUCURSAL',
	@fk_Usuario					int=NULL,
	@fk_Producto				int=NULL,
	@Nombre						varchar(20)=NULL,
	@Descripcion				varchar(20)=NULL,
	@Cantidad					float=NULL,
	@Descuento					float=null,
	@Categoria					varchar(20)=null,
	@Precio						float=null

	)
	AS
BEGIN
	BEGIN TRANSACTION

	IF @Opc = 'InsertCarrito'
	BEGIN 
	INSERT INTO Carrito (Estado,Envio,fk_Usuario)
		VALUES(@Estado,@Envio,@fk_Usuario);
	END	

	
	IF @Opc = 'EJEMPLO'
	BEGIN 

	declare @total float= dbo.Operaciones(@Precio ,@Cantidad )
	declare @descuentoto2 float= dbo.PrecioDescuentado(@Precio ,@Descuento)
	declare @PrecioDescuentado2 float =dbo.PrecioDescuentado2(@Precio ,@descuentoto2)
	declare @TotalDescuento2 float= @Cantidad*@PrecioDescuentado2;
	declare @Ahorrado float = @Cantidad*(@Precio -@PrecioDescuentado2);
		
		INSERT INTO EJEMPLO(fk_Usuario,fk_Producto,Precio,Descuento,Cantidad,Total,PrecioDescuentado2,TotalDescuentado,Nombre,Categoria,Descripcion,Ahorrado)
		values(@fk_Usuario,@fk_Producto,@Precio,@Descuento,@Cantidad,@total,@PrecioDescuentado2,@TotalDescuento2,@Nombre,@Categoria,@Descripcion,@Ahorrado);


	END	
			IF @Opc = 'SelectAll2'
    BEGIN
        SELECT fk_Usuario, fk_Producto,Categoria,Descripcion,Nombre,Precio,Descuento,Cantidad,Precio,Total,TotalDescuentado,PrecioDescuentado2,Ahorrado
        FROM EJEMPLO
    END


				IF @Opc = 'CarritoPro'
    BEGIN
        SELECT fk_Usuario, fk_Producto,Categoria,Descripcion,Nombre,Precio,Descuento,Cantidad,Precio,Total,TotalDescuentado,PrecioDescuentado2,Ahorrado
        FROM EJEMPLO
		where fk_Usuario=@fk_Usuario
    END




			IF @Opc = 'ListaCarrito'
    BEGIN
        SELECT fk_Usuario, fk_Producto,Categoria,Descripcion,Nombre,Precio,Descuento,Cantidad,Precio,Total,TotalDescuentado,PrecioDescuentado2,Ahorrado
        FROM EJEMPLO
		where fk_Usuario=@fk_Usuario
    END

	IF @Opc = 'Total'
    BEGIN
	SELECT  
	SUM(TotalDescuentado) Total FROM EJEMPLO where fk_Usuario=@fk_Usuario

	END


		IF @Opc = 'Envio'
    BEGIN
	SELECT * from DATOS_SUCURSAL where Nombre =@Nombre

	END

	
		IF @Opc = 'GetCarrito'
    BEGIN
	SELECT * from Carrito 

	END



	IF @Opc = 'TotalSinDescuento'
    BEGIN
	SELECT  
	SUM(Total) Total_Sin_Descuento FROM EJEMPLO;

	END


		IF @Opc = 'SelectAll'
    BEGIN
        SELECT fk_Usuario, fk_Producto,Categoria,Descripcion,Nombre,Precio,Descuento,Cantidad,Precio,Total,TotalDescuentado,PrecioDescuentado2,Ahorrado
        FROM EJEMPLO
		where fk_Producto=@fk_Producto
    END

		IF @Opc = 'individual'
    BEGIN
        SELECT fk_Usuario, fk_Producto,Categoria,Descripcion,Nombre,Precio,Descuento,Cantidad,Precio,Total,TotalDescuentado,PrecioDescuentado2,Ahorrado
        FROM EJEMPLO
		where fk_Producto=@fk_Producto AND fk_Usuario=@fk_Usuario
    END


	IF @Opc='EliminarProducto'
	BEGIN	
		DELETE FROM EJEMPLO
	 WHERE fk_Producto= @fk_Producto AND fk_Usuario=@fk_Usuario
END


	IF @Opc='Pagado'
	BEGIN	
		
		update Carrito
			set Estado=ISNULL('PAGADO',Estado)
			where fk_Usuario=@fk_Usuario		
END
	IF @@ERROR = 0
		COMMIT
	ELSE
		ROLLBACK
END
select * from Carrito
select * from EJEMPLO







EXEC sp_Carrito 'InsertCarrito',@fk_Usuario=4

EXEC sp_Carrito @Opc='InsertProductoCarrito',@fk_Usuario=4,@fk_Producto=1,@Nombre='platanito',@Categoria='fruta',@Descripcion='Ta amarillo',@Precio=6,@Cantidad=2,@Descuento=40
Select * from Carrito
select * from CarritoProducto
EXEC sp_Carrito 'EJEMPLO', @fk_Usuario=4,@fk_Producto=1,@Precio=100,@Descuento=20,@Cantidad=9,@Nombre='platanito',@Categoria='fruta',@Descripcion='Ta amarillo'
EXEC sp_Carrito 'EJEMPLO'

SELECT * FROM ejemplo
-------PRODUCTO-------
Create TABLE Producto(
id_Producto INT primary key IDENTITY(1,1),
fk_Empleados int not null,

CONSTRAINT fk_producto FOREIGN KEY(fk_Empleados) REFERENCES Empleados(Id_Empleados),
)
Create TABLE Precio(
fk_Producto int not null,
Precio float not null,
Descuento float,
CONSTRAINT fk_Precio FOREIGN KEY(fk_Producto) REFERENCES Producto(id_Producto),
)
Create TABLE DatosPrecio(
fk_Producto int not null,
Nombre varchar(20) not null,
Descripcion varchar(20) not null,
Categoria varchar(20) not null,
CONSTRAINT fk_DatosPrecio FOREIGN KEY(fk_Producto) REFERENCES Producto(id_Producto),
)
drop table Precio,DatosPrecio,Producto


select 


drop table EJEMPLO
