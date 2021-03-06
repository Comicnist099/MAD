USE Tutorial
GO

IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Usuarios' AND type = 'P')
BEGIN
	DROP PROCEDURE sp_Usuarios;
END
GO

CREATE PROCEDURE sp_Usuarios(
	@Opc				VARCHAR(20),
	@IdUsuario			INT = NULL,
	@NombreUsuario		VARCHAR(20) = NULL,
	@Contraseņa			VARCHAR(20) = NULL,
	@SuperUser			BIT = NULL,
	@Activo				BIT = NULL,
	@MantenerSesion		BIT = NULL
)
AS
BEGIN
	BEGIN TRANSACTION

	IF @Opc = 'Insert'
	BEGIN 
	INSERT INTO Usuarios(Nombre, Contraseņa, SuperUser)
		VALUES(@NombreUsuario, @Contraseņa, @SuperUser);
	END

	IF @Opc = 'GetID'
	BEGIN 
		SELECT IdUsuario
		FROM Usuarios
		WHERE Nombre = @NombreUsuario
	END

	IF @Opc = 'Delete'
	BEGIN
		DELETE
		FROM Usuarios
		WHERE IdUsuario = @IdUsuario
	END
	
	IF @Opc = 'Update'
	BEGIN
		UPDATE Usuarios
			SET Nombre = ISNULL(@NombreUsuario, Nombre),
				Contraseņa = ISNULL(@Contraseņa, Contraseņa),
				SuperUser = ISNULL(@SuperUser, SuperUser)
		WHERE IdUsuario = @IdUsuario
		AND Activo = @Activo
	END

	IF @Opc = 'Disable'
	BEGIN
		UPDATE Usuarios
			SET Activo = 0
		WHERE Nombre = @NombreUsuario
		AND Activo = 1
	END

	IF @Opc = 'Rehabilitate'
	BEGIN
		UPDATE Usuarios
			SET Activo = 1
		WHERE Nombre = @NombreUsuario
		AND Activo = 0
	END

	IF @Opc = 'LogIn'
	BEGIN
		SELECT Contraseņa
			FROM Usuarios
		WHERE Nombre = @NombreUsuario
		AND Activo = @Activo
	END

	IF @Opc = 'Select'
	BEGIN
		SELECT Nombre,
			Contraseņa
			FROM Usuarios
		WHERE Activo = @Activo
		--AND SuperUser = @SuperUser
		ORDER BY Nombre
	END

	IF @Opc = 'RememberSession'
	BEGIN
		UPDATE Usuarios
			SET Persistent = 1
		WHERE Nombre = @NombreUsuario
		AND Persistent = 0
	END

	IF @Opc = 'ForgetSession'
	BEGIN
		UPDATE Usuarios
			SET Persistent = 0
		WHERE Nombre = @NombreUsuario
		AND Persistent = 1
	END

	IF @Opc = 'LogInDefault'
	BEGIN
		SELECT Nombre, Contraseņa
			FROM Usuarios
		WHERE Persistent = 1
	END

	IF @@ERROR = 0
		COMMIT
	ELSE
		ROLLBACK
END