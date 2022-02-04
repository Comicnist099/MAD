Use MAD
DROP PROCEDURE sp_Horas

CREATE PROCEDURE sp_Horas(
	@Opc						VARCHAR(20),
	@id_Horas					int=null,
	@Id_Empleado				int =null,
	@Hora_Entrada				varchar(30)=null,
	@Hora_Salida				varchar(30)=null,
	@Fecha						date=null

)
AS
BEGIN
	BEGIN TRANSACTION

	IF @Opc = 'Insert'
	BEGIN 
	INSERT INTO Horas(fk_Empleado,Hora_Entrada,Hora_Salida,Fecha)
		VALUES(@Id_Empleado,@Hora_Entrada,@Hora_Salida,GETDATE());
	END
	IF @@ERROR = 0
		COMMIT
	ELSE
		ROLLBACK
END

EXEC sp_Horas @Opc='Insert',@Id_Empleado=19,@Hora_Entrada='10:00 am',@Hora_Salida='10:39 pm'

select * from Horas