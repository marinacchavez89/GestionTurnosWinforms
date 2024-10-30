Create Database GestionTurnos
GO
Use GestionTurnos
GO

Create Table Especialidad(
	idEspecialidad int not null Primary Key Identity(1,1),
	Nombre varchar(30) not null unique
)
GO

Create Table Pais(
	idPais int not null Primary Key Identity(1,1),
	Nombre varchar(30) not null unique 
)
GO

Create Table Provincia(
	idProvincia int not null Primary Key Identity(1,1),
	Nombre varchar(30) not null,
	idPais int not null Foreign Key references Pais(idPais)
)
GO

Create Table Ciudad(
	idCiudad int not null Primary Key Identity(1,1),
	Nombre varchar(30) not null,
	idProvincia int not null Foreign Key references Provincia(idProvincia)
)
GO

Create Table Direccion(
	idDireccion int not null Primary Key Identity(1,1),
	Calle varchar(30) not null,
	idCiudad int not null Foreign Key references Ciudad(idCiudad)
)
GO

Create Table Consultorio(
	idConsultorio int not null Primary Key Identity(1,1),
	NumeroConsultorio int not null constraint CHK_NumeroConsultorio check (NumeroConsultorio > 0)
)
GO

Create Table DatosPersonales(
	DNI int not null Primary Key,
	Nombre varchar(30) not null,
	Apellido varchar(30) not null,
	FechaNacimiento date not null,
	idDireccion int not null Foreign Key references Direccion(idDireccion),
	Email varchar(100) not null unique,
	Telefono varchar(15) not null constraint CHK_Telefono check (Telefono like '[0-9]%')
)
GO


Create Table Profesional(
	idProfesional int not null Primary Key Identity(1,1),
	Matricula INT not null unique,
	idEspecialidad int not null Foreign Key references Especialidad(idEspecialidad),
	Honorario money not null constraint CHK_HonorarioProfesional check (Honorario >0),
	DNI int not null  Foreign Key references DatosPersonales(DNI),
	Activo bit not null default 1
)
GO

Create Table HorariosProfesionales(
	idMatricula int not null foreign key references Profesional(Matricula),
	idConsultorio int not null Foreign Key references Consultorio(idConsultorio),
	DiaAtencion tinyint not null constraint CHK_DiaAtencion check(DiaAtencion between 1 and 7),
	HoraInicio time not null,
	HoraFin time not null,
	Primary key(idMatricula, DiaAtencion, HoraInicio)
)
GO

Create Table Cobertura(
	idCobertura int not null Primary Key Identity(1,1),
	Nombre varchar(30) not null,
	PorcentajeCobertura int not null constraint CHK_PorcentajeCobertura check (PorcentajeCobertura between 1 and 100),
	Activo bit not null default 1
)
GO

Create Table Paciente(
	idPaciente int not null Primary Key Identity(1,1),
	idCobertura int not null Foreign Key references Cobertura(idCobertura),
	DNI int not null unique Foreign Key references DatosPersonales(DNI),
	Activo bit not null default 1
)
GO

Create Table EstadoTurno(
    idEstadoTurno int not null Primary Key Identity(1,1),
    Descripcion varchar(20) not null
)
GO

Create Table Turno(
    idTurno int not null Primary Key Identity(1,1),
    Matricula int not null Foreign Key references Profesional(Matricula) on delete cascade,
    idPaciente int not null Foreign Key references Paciente(idPaciente) on delete cascade,
    FechaTurno datetime not null,
    idEstadoTurno int not null Foreign Key references EstadoTurno(idEstadoTurno),
	HonorarioConsulta money null
)
GO

CREATE TABLE Profesional_Especialidad(
    Matricula int not null Foreign Key references Profesional(Matricula),
    idEspecialidad int not null Foreign Key references Especialidad(idEspecialidad),
    Primary Key(Matricula, idEspecialidad)
);
GO

CREATE TABLE Cobertura_Especialidad(
    idCobertura int not null Foreign Key references Cobertura(idCobertura),
    idEspecialidad int not null Foreign Key references Especialidad(idEspecialidad),
    Primary Key(idCobertura, idEspecialidad)
);
GO
