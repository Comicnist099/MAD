Use MAD

create trigger TR_DatosPersonales

on DatosPersonales

for insert 

as
print 'hubo un dado de alta en DatosPersonales';

create trigger TR_DatosPersonalesEmpleados

on DatosPersonalesEmpleado

for insert 

as
print 'hubo un dado de alta en DatosPersonales de Empleado como toda su información';


create trigger TR_DatosPersonales

on DatosPersonales

for insert 

as
print 'hubo un dado de alta en DatosPersonales';






DROP PROCEDURE sp_Usuario

alter PROCEDURE sp_Usuario(
	@Opc						VARCHAR(20),
	@ID_Usuario					INT = NULL,
	@Fecha_de_Alta				DATE = NULL,
	@Fecha_de_Modificacion		DATE = NULL,
	@Fecha_de_Nacimiento		DATE = NULL,
	@Nombre						VARCHAR(50) = NULL,
	@ApPaterno					VARCHAR(50) = NULL,
	@ApMaterno					VARCHAR(50) = NULL,  
	@Nombre_Usuario    			VARCHAR(50) = NULL,
    @Contrasena      			VARCHAR(50) = NULL,
	@MetodoPago					VARCHAR(50) = NULL,
	@Correo						VARCHAR(50) = NULL,
	@CURP						VARCHAR(50) = NULL,
	@Domicilio				    VARCHAR(50) = NULL,
	@Celular					VARCHAR(55) = NULL,
	@Estado						VARCHAR(50) = 'ACTIVO'
)

AS
BEGIN
	BEGIN TRANSACTION

	IF @Opc = 'Insert'
	BEGIN 
	INSERT INTO USUARIO(Fecha_de_alta)
		VALUES(GETDATE());

	declare @idUsuario int = IDENT_CURRENT('USUARIO')

	INSERT INTO DatosPersonales(fk_Usuario,Nombre,Apellido_M,Apellido_P,Correo,CURP,Fecha_de_nacimiento,Celular,Domicilio)
		VALUES(@idUsuario,@Nombre,@ApMaterno,@ApPaterno,@Correo,@CURP,@Fecha_de_Nacimiento,@Celular,@Domicilio);

	INSERT INTO MetodoPago(fk_Usuario,MetodoPago)
		VALUES(@idUsuario,@MetodoPago);

	INSERT INTO Cuenta(fk_Usuario,Nombre_Usuario, Contraseña,Estado)
		VALUES(@idUsuario ,@Nombre_Usuario,@Contrasena,@Estado);
	END

		IF @Opc = 'Delete'
	BEGIN
		DELETE FROM DatosPersonales WHERE fk_Usuario= @ID_Usuario
		DELETE FROM Cuenta WHERE  fk_Usuario= @ID_Usuario
		DELETE FROM MetodoPago WHERE  fk_Usuario= @ID_Usuario
		DELETE FROM USUARIO WHERE  ID_Usuario= @ID_Usuario
	END

	IF @Opc = 'Update'
	BEGIN
		UPDATE USUARIO
			SET Fecha_de_Modificacion = ISNULL(GETDATE(), Fecha_de_Modificacion) WHERE ID_Usuario = @ID_Usuario;
		UPDATE DatosPersonales
			SET Nombre = ISNULL(@Nombre, Nombre),
				Apellido_M = ISNULL(@ApMaterno, Apellido_M),
				Apellido_P = ISNULL(@ApPaterno, Apellido_P),
				Correo = ISNULL(@Correo, Correo),
				CURP = ISNULL(@CURP, CURP),
				Fecha_de_nacimiento = ISNULL(@Fecha_de_nacimiento, Fecha_de_nacimiento),
				Celular = ISNULL(@Celular, Celular),
				Domicilio = ISNULL(@Domicilio, Domicilio)
				WHERE fk_Usuario = @ID_Usuario;
		UPDATE  MetodoPago
			SET MetodoPago= ISNULL(@MetodoPago,MetodoPago) WHERE fk_Usuario= @ID_Usuario
		UPDATE Cuenta
			SET Nombre_Usuario=ISNULL(@Nombre_Usuario,Nombre_Usuario),
			    Contraseña = ISNULL(@Contrasena,Contraseña)
				WHERE fk_Usuario=@ID_Usuario
	END

	IF @Opc = 'LogIn'
	BEGIN
		SELECT Contraseña FROM Cuenta
		WHERE Nombre_Usuario = @Nombre_Usuario
	END

	IF @Opc = 'SearchUser'
	BEGIN 
		SELECT fk_Usuario
		FROM Cuenta
		WHERE fk_Usuario = @ID_Usuario
	END
	

	IF @Opc = 'Select'
	BEGIN
		SELECT Nombre_Usuario,	Contraseña FROM Cuenta
		ORDER BY Nombre_Usuario
	END

	
	IF @Opc = 'SelectTODOS'
	BEGIN
		SELECT * FROM DatosPersonales
		where fk_Usuario=@ID_Usuario
		
	END

	IF @Opc = 'SelectIntentos'
	BEGIN
		SELECT Nombre_Usuario,	Contraseña FROM Cuenta
		ORDER BY Nombre_Usuario
	END

	IF @Opc = 'GetID'
    BEGIN 
        SELECT fk_Usuario
        FROM Cuenta
        WHERE Nombre_Usuario = @Nombre_Usuario
    END
	
    IF @Opc = 'Disable'
    BEGIN
        UPDATE Cuenta
            SET Estado = 'DESACTIVADO'
        WHERE Nombre_Usuario = @Nombre_Usuario

    END

	IF @Opc = 'Activo'
    BEGIN
        UPDATE Cuenta
            SET Estado = 'ACTIVO'
        WHERE Nombre_Usuario = @Nombre_Usuario

    END


	  IF @Opc = 'Activo?'
    BEGIN
        SELECT Estado
           from Cuenta  
        WHERE Nombre_Usuario = @Nombre_Usuario

    END

	IF @Opc = 'SelectAll'
    BEGIN
        SELECT ID_Usuario
        FROM USUARIO
		where ID_Usuario=@ID_Usuario
    END

	IF @Opc = 'SelectAll2'
    BEGIN
        SELECT Nombre_Usuario, Contraseña,Estado,fk_Usuario
        FROM Cuenta
		where Nombre_Usuario=@Nombre_Usuario
    END
		IF @Opc = 'SelectAll3'
    BEGIN
        SELECT Nombre_Usuario, Contraseña,Estado,fk_Usuario
        FROM Cuenta
		
    END
 

	IF @@ERROR = 0
		COMMIT
	ELSE
		ROLLBACK
END

----EJEMPLO PARA LLENADO DE INFO----------------- 
Exec sp_Usuario 'Insert', NULL,NULL,NULL,'2000-01-01','a','b','c','d','e','f','g','h','i','j','k'


-------EJEMPLO PARA MODIFICAR INFO-----------
Exec sp_Usuario 'Update', 4,NULL,NULL,'2000-03-01','b','b','b','b','b','b','b','b','b','b','b'



-----------PRUEBA DE PROCEDURE--------------
Exec sp_Usuario 'LogIn', @ID_Usuario=3,@Nombre_Usuario='e'
Exec sp_Usuario 'Delete', @ID_Usuario=1


use MAD
----VER TABLAS------
Select *from USUARIO
Select *from DatosPersonales
Select *from MetodoPago
Select *from Cuenta




alter proc pb_Mostrar
@id int
as
select Nombre, Apellido_M,Apellido_P,Domicilio from DatosPersonales where fk_Usuario=@id
go



create proc pb_Sucursal
@Nombre varchar(100)
as
select * from Datos_Sucursal where Nombre=@Nombre
go


alter proc pb_Carrito
@id_Usuario int
as
select  fk_Producto, Nombre, Descripcion,Categoria,Precio, Descuento,Cantidad,PrecioDescuentado2,Total,TotalDescuentado,Ahorrado from EJEMPLO where fk_Usuario=@id_Usuario
go


SELECT SUM(TotalDescuentado) Total FROM EJEMPLO;

create proc pb_Total
@id_Usuario int
as
SELECT SUM(TotalDescuentado) Total FROM EJEMPLO where fk_Usuario=@id_Usuario
go

create proc pb_Pagado
@id_Usuario int
as
SELECT Estado FROM Carrito where fk_Usuario=@id_Usuario
go

Select * from Carrito

select * from Ejemplo

delete from Carrito where fk_Usuario=1



create proc pb_Ordenar

as
select * from Ejemplo ORDER BY fk_Usuario
go
