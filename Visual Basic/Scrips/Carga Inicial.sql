USE Tutorial;
--Ctrl + R: Quitar le tabla


INSERT INTO Puestos(NombrePuesto) VALUES('Velador');
INSERT INTO Puestos(NombrePuesto) VALUES('Contador');
INSERT INTO Puestos(NombrePuesto) VALUES('Director');
INSERT INTO Puestos(NombrePuesto) VALUES('Ayudante');
INSERT INTO Puestos(NombrePuesto) VALUES('Gerente');
EXEC sp_Puestos 'I', NULL, 'Subdirector', 5.25; --Insertar puesto
EXEC sp_Puestos 'I', NULL, 'Presidente', 10.50;
EXEC sp_Puestos 'I', NULL, 'Vicepresidente', 8;
EXEC sp_Puestos 'I', NULL, 'Manager', 2.25
EXEC sp_Puestos 'B', 104 --Dar de baja puesto
EXEC sp_Puestos 'U', 103, 'Chef', NULL --Actualizar el puesto 103
EXEC sp_Puestos 'U', 105, NULL, 5.52
EXEC sp_Puestos 'X'

EXEC sp_Usuarios 'Insert', NULL, 'RickySP', 'Tailsmo', 1
EXEC sp_Usuarios 'Insert', NULL, 'elponkys', 'Twintelle', 1
EXEC sp_Usuarios 'LogIn', NULL, 'RickySP', NULL, NULL, 1 --Login
EXEC sp_Usuarios 'Disable', NULL, 'elponkys' --Inhabilitar
EXEC sp_Usuarios 'Rehabilitate', NULL, 'elponkys' --Habilitar
EXEC sp_Usuarios 'Select', NULL, NULL, NULL, NULL, 1 --Usuarios Activos
EXEC sp_Usuarios 'Select', NULL, NULL, NULL, NULL, 0 --Usuarios Inactivos
EXEC sp_Usuarios 'RememberSession', NULL, 'RickySP' --Mantener sesión
EXEC sp_Usuarios 'ForgetSession', NULL, 'RickySP' --Deshabilitar sesión
EXEC sp_Usuarios 'LogInDefault' --Sesión mantenida

EXEC sp_Empleados 'Insert', NULL, 1, NULL, 106, 'Victor Ricardo', 'Amaya', 'Porchini', 'victor.amayaphn@uanl.edu.mx', '19991101', '12345678901', 'AAPV991101HNLMRC', 'AAPV991101', '8131350502'
EXEC sp_Empleados 'Insert', NULL, 2, NULL, 106, 'Kevin Abraham', 'Gonzalez', 'Guerrero', 'kevin.gonzalezgrr@uanl.edu.mx', '20000720', '10987654321', 'GOGK000720HNLNRV', 'GOGK000720', '8126899799'

EXEC sp_Puestos 'X'
EXEC sp_Usuarios 'Select', NULL, NULL, NULL, NULL, 1
EXEC sp_Empleados 'SelectAll'

Select * from Usuarios
Select * from Puestos
Select * from Empleados