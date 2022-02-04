--Data Definition Language (DDL)
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Tutorial' AND type = 'D')
BEGIN
	DROP DATABASE Tutorial;
END
CREATE DATABASE Tutorial;
USE Tutorial; --Cambiar a la base de datos Tutorial
--DROP DATABASE Tutorial; --Borrar la base de datos Tutorial
GO;

IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME = 'Empleados' AND TYPE = 'U')
BEGIN
	DROP TABLE Empleados;
END
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME = 'Puestos' AND TYPE = 'U')
BEGIN
	DROP TABLE Puestos;
END
IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME = 'Usuarios' AND TYPE = 'U')
BEGIN
	DROP TABLE Usuarios;
END

--Tabla de Usuarios
CREATE TABLE Usuarios(
	IdUsuario		INT NOT NULL IDENTITY(1, 1),
	Nombre			VARCHAR(20) UNIQUE NOT NULL /*Su nombre lo dice todo*/,
	Contraseña		VARCHAR(20) NOT NULL,
	SuperUser		BIT NOT NULL,
	Activo			BIT DEFAULT(1),
	Persistent		BIT DEFAULT(0),
	CONSTRAINT PK_USER PRIMARY KEY (IdUsuario)
);
GO

--Tabla de Puestos
CREATE TABLE Puestos(
	IdPuesto		TINYINT NOT NULL IDENTITY(100,1) /*El IDENTITY(Número inicial, cuanto aumenta) te genera automáticamente un id al momento de añadir una nueva fila a la tabla*/,
	NombrePuesto	VARCHAR(20) NOT NULL,
	Nivel			DECIMAL (5, 2) NOT NULL DEFAULT(1.0),
	Activo			BIT NOT NULL DEFAULT(1) /*0 = No Activo, 1 = Activo*/,
	CONSTRAINT PK_PUESTO PRIMARY KEY (IdPuesto) /*Definición de la Primary Key (O Llave Primaria)*/
);
GO

--Tabla de Empleados
CREATE TABLE Empleados(
	IdEmpleado		INT NOT NULL IDENTITY(1, 1),
	Nombre			VARCHAR(30) NOT NULL,
	ApPaterno		VARCHAR(30) NOT NULL,
	ApMaterno		VARCHAR(30) NOT NULL,
	Email			VARCHAR(50) NULL,
	FNac			DATE NOT NULL,
	NSS				CHAR(11) NOT NULL,
	CURP			CHAR(18) NOT NULL,
	RFC				CHAR(13) NULL,
	Telefono		CHAR(10) NULL,
	PuestoID		TINYINT NOT NULL,
	UsuarioID		INT UNIQUE NOT NULL,
	CONSTRAINT PK_EMPLOYEE PRIMARY KEY (IdEmpleado),
	CONSTRAINT FK_PUESTOID FOREIGN KEY (PuestoID) REFERENCES Puestos(IdPuesto) /*Definición de la Foreign Key (O Llave Foranea)*/,
	CONSTRAINT FK_USERID FOREIGN KEY (UsuarioID) REFERENCES Usuarios(IdUsuario)
);
GO

--Alt+F1
sp_help 'Empleados' --Muestra la tabla Empleados