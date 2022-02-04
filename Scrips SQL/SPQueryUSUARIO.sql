USE MAD;

alter view SelectAll2
as
	SELECT Nombre_Usuario, Contraseña,Estado,fk_Empleado
	FROM Cuentas





drop procedure sp_Empleados
alter PROCEDURE sp_Empleados(
    @Opc                        VARCHAR(20),
    @ID                            INT = NULL,
    @Fecha_de_Alta                DATE = NULL,
    @Fecha_de_Modificacion        DATE = NULL,
    @Fecha_de_Nacimiento        DATE = NULL,
    @RFC                        VARCHAR(40) = NULL,
    @Nombre                        VARCHAR(20) = NULL,
    @ApPaterno                    VARCHAR(20) = NULL,
    @ApMaterno                    VARCHAR(20) = NULL,  
    @Nombre_Usuario                VARCHAR(30) = NULL,
    @Contrasena                  VARCHAR(30) = NULL,
    @Rol                        VARCHAR(50) = NULL,
    @Correo                        VARCHAR(30) = NULL,
    @CURP                        VARCHAR(30) = NULL,
    @Domicilio                    VARCHAR(30) = NULL,
    @Celular                    VARCHAR(15) = NULL,
    @Estado                        VARCHAR(20) ='Activo' 
)
AS
BEGIN
    BEGIN TRANSACTION

    IF @Opc = 'Insert'
    BEGIN 
    INSERT INTO Empleados(Fecha_de_alta)
        VALUES(GETDATE());

    declare @idEmpleado int = IDENT_CURRENT('Empleados')

    INSERT INTO DatosPersonalesEmpleado(fk_Empleado,Nombre,Apellido_M,Apellido_P,Correo,RFC,CURP,Fecha_de_nacimiento,Celular,Domicilio)
        VALUES(@idEmpleado,@Nombre,@ApMaterno,@ApPaterno,@Correo,@RFC,@CURP,@Fecha_de_Nacimiento,@Celular,@Domicilio);

    INSERT INTO Rol(fk_Empleado,Rol)
        VALUES(@idEmpleado,@Rol);

    INSERT INTO Cuentas(fk_Empleado,Nombre_Usuario, Contraseña,Estado)
        VALUES(@idEmpleado ,@Nombre_Usuario,@Contrasena,@Estado);
    END


    IF @Opc = 'Delete'
    BEGIN
        DELETE FROM DatosPersonalesEmpleado WHERE fk_Empleado= @ID
        DELETE FROM Cuentas WHERE  fk_Empleado= @ID
        DELETE FROM Rol WHERE  fk_Empleado= @ID
        DELETE FROM Empleados WHERE  Id_Empleados= @ID

	END
        IF @Opc = 'LogIn'
    BEGIN
        SELECT Contraseña FROM Cuentas
        WHERE Nombre_Usuario = @Nombre_Usuario 
    END

	IF @Opc = 'GetID'
    BEGIN 
        SELECT fk_Empleado
        FROM Cuentas
        WHERE Nombre_Usuario = @Nombre_Usuario
    END

	IF @Opc = 'SearchUser'
    BEGIN 
        SELECT fk_Empleado
        FROM Cuentas
        WHERE fk_Empleado = @ID
    END

	IF @Opc = 'Select'
    BEGIN
        SELECT fk_Empleado, Nombre_Usuario,  Contraseña 
		FROM Cuentas 
		where fk_Empleado=@ID
        
    END
	IF @Opc = 'Update'
    BEGIN
        UPDATE Empleados
            SET Fecha_de_Modificacion = ISNULL(GETDATE(), Fecha_de_Modificacion) WHERE Id_Empleados = @ID;
        UPDATE DatosPersonalesEmpleado
            SET Nombre = ISNULL(@Nombre, Nombre),
                Apellido_M = ISNULL(@ApMaterno, Apellido_M),
                Apellido_P = ISNULL(@ApPaterno, Apellido_P),
                Correo = ISNULL(@Correo, Correo),
                RFC = ISNULL(@RFC, RFC),
                CURP = ISNULL(@CURP, CURP),
                Fecha_de_nacimiento = ISNULL(@Fecha_de_nacimiento, Fecha_de_nacimiento),
                Celular = ISNULL(@Celular, Celular),
                Domicilio = ISNULL(@Domicilio, Domicilio)
                WHERE fk_Empleado = @ID;
        UPDATE  Rol
            SET Rol= ISNULL(@Rol,Rol) WHERE fk_Empleado= @ID
        UPDATE Cuentas
            SET Nombre_Usuario=ISNULL(@Nombre_Usuario,Nombre_Usuario),
                Contraseña = ISNULL(@Contrasena,Contraseña)
                WHERE fk_Empleado=@ID
    END

	IF @Opc = 'Select2'
    BEGIN
        SELECT  fk_Empleado, Nombre, Apellido_M,Apellido_P 
		FROM DatosPersonalesEmpleado 
		where fk_Empleado=@ID
       
    END

	IF @Opc = 'Select3'
    BEGIN
        SELECT fk_empleado, Rol 
		FROM Rol 
		where fk_Empleado=@ID
        
    END

    IF @Opc = 'Disable'
    BEGIN
        UPDATE Cuentas
            SET Estado = 'Desactivado'
        WHERE Nombre_Usuario = @Nombre_Usuario
       
    END

	IF @Opc = 'TODOS'
    BEGIN
        
		SELECT *
        FROM DatosPersonalesEmpleado
				
    END

	IF @Opc = 'TODOS2'
    BEGIN
        SELECT *
        FROM Cuentas
		
    END

	
	IF @Opc = 'TODOS3'
    BEGIN
        SELECT *
        FROM DatosPersonalesEmpleado
		where fk_Empleado=@ID
		
    END


	IF @Opc = 'SelectAll'
    BEGIN
        SELECT Id_Empleados
        FROM Empleados
		where Id_Empleados=@ID
    END
	IF @Opc = 'SelectAll2'
    BEGIN
        SELECT *from SelectAll2
        
    END

	IF @Opc = 'SelectAll4'
    BEGIN
        SELECT Nombre_Usuario, Contraseña,Estado,fk_Empleado
        FROM Cuentas
		where Nombre_Usuario=@Nombre_Usuario
    END

	IF @Opc = 'SelectAll5'
    BEGIN
        SELECT Nombre_Usuario, Contraseña,Estado
        FROM Cuentas
		where Nombre_Usuario=@Nombre_Usuario
    END

		IF @Opc = 'rol'
    BEGIN
        SELECT *
        FROM Rol
		where fk_Empleado=@ID
    END

	
	IF @Opc = 'Activo'
    BEGIN
        UPDATE Cuentas
            SET Estado = 'Activo'
        WHERE Nombre_Usuario = @Nombre_Usuario

    END


	IF @Opc = 'SelectAll3'
    BEGIN
        SELECT Nombre, Apellido_M,Apellido_P,Correo,RFC,CURP,Fecha_de_Nacimiento,Celular,Domicilio
        FROM DatosPersonalesEmpleado
		where fk_Empleado=@ID
    END
 
    IF @@ERROR = 0
        COMMIT
    ELSE
        ROLLBACK
END

----------------------------------------------------------------------------------------------------------------
----------Agregar informacion-------------------------
EXEC sp_Empleados 'Insert',Null,Null,NULL,'2000-03-04','RUG0009','Victoria','Rivas','Salas','choripapa','mariobros00','Empleado','vik.rivas00@gmail.com','RISV00001','Maple 238, Los Laureles, San Nicolas','8183848586','Activo'
EXEC sp_Empleados 'Insert',Null,Null,NULL,'1999-09-29','PRG0009','Marco','Cantu','Castillo','MaquinaFuego','Elzelda5','Admin','xholitoemoxito@gmail.com','MARC00001','Encino 136, Paseo los angeles, San Nicolas','81563567','Activo'
EXEC sp_Empleados 'Insert',Null,Null,NULL,'1999-02-11','KPS0009','Monica','Soto','Sanchez','KiraLover','shingeki1','Empleado','Kageyoshi@gmail.com','MONI00001','Gral. Elias 308, Revolucion, Guadalupe','84763019','Activo'
EXEC sp_Empleados 'Insert',Null,Null,NULL,'2001-12-17','KPS0009','Teresita','De Jesus','Rodriguez','littleT','starco','Empleado','regulart@gmail.com','TERE00001','Gral. Elias 308, Revolucion, Guadalupe','84883019','Activo'

---------Datos del empleado-------------------------
SELECT *from Empleados

SELECT *from Cuentas

SELECT *from DatosPersonalesEmpleado

SELECT *from Rol
Use MAd


---------------Borrar Procedure---------------------------
DROP PROCEDURE sp_Empleados;

---------------Borrar Datos de la tablas ------------
DELETE from Empleados WHERE Id_Empleados = 3


EXEC sp_Empleados 'Delete',@ID= 3