USE GestionTurnos;

INSERT INTO Especialidad (Nombre) VALUES 
('Cardiología'),
('Dermatología'),
('Pediatría');

INSERT INTO Pais (Nombre) VALUES 
('Argentina');

INSERT INTO Provincia (Nombre, idPais) VALUES 
('Buenos Aires', 1),
('Santa Fe', 1);

INSERT INTO Ciudad (Nombre, idProvincia) VALUES 
('Mar del Plata', 1),
('Rosario', 2);

INSERT INTO Direccion (Calle, idCiudad) VALUES 
('Avenida Colón 123', 1),
('Calle San Martín 456', 2);

INSERT INTO Consultorio (NumeroConsultorio) VALUES 
(1),
(2),
(3),
(4);

INSERT INTO DatosPersonales (DNI, Nombre, Apellido, FechaNacimiento, idDireccion, Email, Telefono) VALUES 
(12345678, 'Juan', 'Pérez', '1985-05-15', 1, 'juan.perez@gmail.com', '2234567890'),
(23456789, 'Ana', 'García', '1990-10-10', 2, 'ana.garcia@gmail.com', '3412345678'),
(34567890, 'Carlos', 'Silva', '1975-07-20', 1, 'carlos.silva@gmail.com', '5523456789'),
(45678901, 'María', 'Rojas', '1988-03-25', 2, 'maria.rojas@gmail.com', '5698765432');

INSERT INTO Profesional (Matricula, idEspecialidad, Honorario, DNI) VALUES 
(95789, 1, 5000, 12345678),
(24785, 2, 4000, 23456789),
(56258, 3, 6000, 34567890);

INSERT INTO HorariosProfesionales (idMatricula, idConsultorio, DiaAtencion, HoraInicio, HoraFin) VALUES 
(95789, 1, 1, '09:00', '12:00'),
(24785, 2, 2, '14:00', '18:00'),
(56258, 3, 3, '08:00', '11:00');

INSERT INTO Cobertura (Nombre, PorcentajeCobertura) VALUES 
('OSDE', 80),
('Swiss Medical', 70),
('Galeno', 60);

INSERT INTO Paciente (idCobertura, DNI) VALUES 
(1, 45678901),
(2, 12345678),
(3, 23456789);

INSERT INTO EstadoTurno (Descripcion) VALUES 
('Otorgado'),
('Finalizado'),
('Cancelado');

INSERT INTO Turno (Matricula, idPaciente, FechaTurno, idEstadoTurno) VALUES 
(95789, 1, '2024-10-15 10:00', 1),
(24785, 2, '2024-10-16 14:00', 2),
(56258, 3, '2024-10-17 09:00', 3);

INSERT INTO Profesional_Especialidad(Matricula, idEspecialidad) VALUES
(95789, 1),
(24785, 2),
(56258, 3);

INSERT INTO Cobertura_Especialidad(idCobertura, idEspecialidad) VALUES
(1, 1),
(2, 2),
(3, 3);
