USE Tutorial
GO

IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Empleados' AND type = 'P')
BEGIN
	DROP PROCEDURE sp_Empleados;
END
GO

CREATE PROCEDURE sp_Empleados(
	@Opc				VARCHAR(20),
	@ID					INT = NULL,
	@UsuarioID			INT = NULL,
	@NombreUsuario		VARCHAR(20) = NULL,
	@PuestoID			TINYINT = NULL,
	@Nombre				VARCHAR(30) = NULL,
	@ApPaterno			VARCHAR(30) = NULL,
	@ApMaterno			VARCHAR(30) = NULL,
	@Email				VARCHAR(50) = NULL,
	@FNac				DATE = NULL,
	@NSS				CHAR(11) = NULL,
	@CURP				CHAR(18) = NULL,
	@RFC				CHAR(13) = NULL,
	@Telefono			CHAR(10) = NULL
)
AS
BEGIN
	BEGIN TRANSACTION

	IF @Opc = 'Insert'
	BEGIN 
	INSERT INTO Empleados(Nombre, ApPaterno, ApMaterno, Email, FNac, NSS, CURP, RFC, Telefono, PuestoID, UsuarioID)
		VALUES(@Nombre, @ApPaterno, @ApMaterno, @Email, @FNac, @NSS, @CURP, @RFC, @Telefono, @PuestoID, @UsuarioID);
	END

	IF @Opc = 'Delete'
	BEGIN
		DELETE
		FROM Empleados
		WHERE IdEmpleado = @ID
	END
	
	IF @Opc = 'Update'
	BEGIN
		UPDATE Empleados
			SET Nombre = ISNULL(@Nombre, Nombre),
				ApPaterno = ISNULL(@ApPaterno, ApPaterno),
				ApMaterno = ISNULL(@ApMaterno, ApMaterno),
				Email = ISNULL(@Email, Email),
				FNac = ISNULL(@FNac, FNac),
				NSS = ISNULL(@NSS, NSS),
				CURP = ISNULL(@CURP, CURP),
				RFC = ISNULL(@RFC, RFC),
				Telefono = ISNULL(@Telefono, Telefono),
				PuestoID = ISNULL(@PuestoID, PuestoID),
				UsuarioID = ISNULL(@UsuarioID, UsuarioID)
		WHERE IdEmpleado = @ID
	END
	
	IF @Opc = 'SelectByUsername'
	BEGIN
		SELECT IdEmpleado 'ID', E.Nombre, ApPaterno 'Apellido paterno', ApMaterno 'Apellido materno', Email, FNac 'Fecha de nacimiento', NSS, CURP, RFC, Telefono 'Teléfono', P.NombrePuesto 'Puesto', E.PuestoID 'ID del Puesto', U.Nombre 'Usuario', U.SuperUser 'Administrador', U.Persistent 'Recordar Contraseña'
			FROM Empleados E
			JOIN Usuarios U
			ON E.UsuarioID = U.IdUsuario
			JOIN Puestos P
			ON E.PuestoID = P.IdPuesto
		WHERE U.Nombre = @NombreUsuario
		--WHERE IdEmpleado = @ID
	END

	IF @Opc = 'SelectAll'
	BEGIN
		SELECT IdEmpleado 'ID', E.Nombre, ApPaterno 'Apellido paterno', ApMaterno 'Apellido materno', Email, FNac 'Fecha de nacimiento', NSS, CURP, RFC, Telefono 'Teléfono', P.NombrePuesto 'Puesto', E.PuestoID 'ID del Puesto', U.Nombre 'Usuario', U.SuperUser 'Administrador', U.Persistent 'Recordar Contraseña'
			FROM Empleados E
			JOIN Usuarios U
			ON E.UsuarioID = U.IdUsuario
			JOIN Puestos P
			ON E.PuestoID = P.IdPuesto
		ORDER BY E.Nombre
	END

	IF @@ERROR = 0
		COMMIT
	ELSE
		ROLLBACK
END