USE Tutorial
GO

IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Puestos' AND type = 'P')
BEGIN
	DROP PROCEDURE sp_Puestos;
END
GO

CREATE PROCEDURE sp_Puestos(
	@Opc				CHAR(1),
	@IdPuesto			INT = NULL,
	@NombrePuesto		VARCHAR(20) = NULL,
	@Nivel				DECIMAL(5,2) = NULL --5 dígitos con 2 decimales
)
AS
BEGIN
	BEGIN TRANSACTION

	DECLARE @Activo		BIT
	SET @Activo = 1;

	IF @Opc = 'I' --Ingresar puesto
	BEGIN 
	INSERT INTO Puestos(NombrePuesto, Nivel, Activo)
		VALUES(@NombrePuesto, @Nivel, @Activo);
	END

	IF @OPC = 'D' --Borrar puesto
	BEGIN
		DELETE
		FROM Puestos
		WHERE IdPuesto = @IdPuesto
		AND Activo = @Activo
	END
	
	IF @OPC = 'U' --Actualizar puesto
	BEGIN
		UPDATE Puestos
			SET NombrePuesto = ISNULL(@NombrePuesto, NombrePuesto),
				Nivel = ISNULL(@Nivel, Nivel)
		WHERE IdPuesto = @IdPuesto
		AND Activo = @Activo
	END

	IF @OPC = 'B' --Dar de baja puesto
	BEGIN
		UPDATE Puestos
			SET Activo = 0
		WHERE IdPuesto = @IdPuesto
		AND Activo = @Activo
	END

	IF @OPC = 'S' --Buscar puesto activo
	BEGIN
		SELECT NombrePuesto 'Nombre', Nivel, Activo
			FROM Puestos
		WHERE IdPuesto = @IdPuesto
		AND Activo = @Activo
	END

	IF @OPC = 'X' --Mostrar puestos activos
	BEGIN
		SELECT IdPuesto 'ID',
			NombrePuesto 'Nombre',
			Nivel,
			Activo
			FROM Puestos
		WHERE Activo = @Activo
		ORDER BY IdPuesto--NombrePuesto --DESC
	END

	IF @@ERROR = 0
		COMMIT
	ELSE
		ROLLBACK
END