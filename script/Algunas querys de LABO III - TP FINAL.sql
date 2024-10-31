select * from Paciente
select * from DatosPersonales
select * from Ciudad
select * from Pais
select * from Provincia

UPDATE Ciudad
SET Nombre = 'CABA'
WHERE idCiudad = 1;

UPDATE Ciudad
SET Nombre = 'Santa Fe'
WHERE idCiudad = 2;

-- Suponiendo que el idPais de Argentina en la tabla Pais es 1
DECLARE @idPais INT;
SET @idPais = 1; -- Cambia esto al idPais correspondiente si es diferente

INSERT INTO Provincia (Nombre, idPais) VALUES 
('Catamarca', @idPais),
('Chaco', @idPais),
('Chubut', @idPais),
('C�rdoba', @idPais),
('Corrientes', @idPais),
('Entre R�os', @idPais),
('Formosa', @idPais),
('Jujuy', @idPais),
('La Pampa', @idPais),
('La Rioja', @idPais),
('Mendoza', @idPais),
('Misiones', @idPais),
('Neuqu�n', @idPais),
('R�o Negro', @idPais),
('Salta', @idPais),
('San Juan', @idPais),
('San Luis', @idPais),
('Santiago del Estero', @idPais),
('Tierra del Fuego', @idPais),
('Tucum�n', @idPais);


DECLARE @idProvinciaCatamarca INT = 4;
DECLARE @idProvinciaChaco INT = 5;
DECLARE @idProvinciaChubut INT = 6;
DECLARE @idProvinciaCordoba INT = 7;
DECLARE @idProvinciaCorrientes INT = 8;
DECLARE @idProvinciaEntreRios INT = 9;
DECLARE @idProvinciaFormosa INT = 10;
DECLARE @idProvinciaJujuy INT = 11;
DECLARE @idProvinciaLaPampa INT = 12;
DECLARE @idProvinciaLaRioja INT = 13;
DECLARE @idProvinciaMendoza INT = 14;
DECLARE @idProvinciaMisiones INT = 15;
DECLARE @idProvinciaNeuquen INT = 16;
DECLARE @idProvinciaRioNegro INT = 17;
DECLARE @idProvinciaSalta INT = 18;
DECLARE @idProvinciaSanJuan INT = 19;
DECLARE @idProvinciaSanLuis INT = 20;
DECLARE @idProvinciaSantiagoDelEstero INT = 21;
DECLARE @idProvinciaTierraDelFuego INT = 22;
DECLARE @idProvinciaTucuman INT = 23;

INSERT INTO Ciudad (Nombre, idProvincia) VALUES 
('San F. Valle Catamarca.', @idProvinciaCatamarca),
('Resistencia', @idProvinciaChaco),
('Rawson', @idProvinciaChubut),
('C�rdoba', @idProvinciaCordoba),
('Corrientes', @idProvinciaCorrientes),
('Paran�', @idProvinciaEntreRios),
('Formosa', @idProvinciaFormosa),
('San Salvador de Jujuy', @idProvinciaJujuy),
('Santa Rosa', @idProvinciaLaPampa),
('La Rioja', @idProvinciaLaRioja),
('Mendoza', @idProvinciaMendoza),
('Posadas', @idProvinciaMisiones),
('Neuqu�n', @idProvinciaNeuquen),
('Viedma', @idProvinciaRioNegro),
('Salta', @idProvinciaSalta),
('San Juan', @idProvinciaSanJuan),
('San Luis', @idProvinciaSanLuis),
('Santiago del Estero', @idProvinciaSantiagoDelEstero),
('Ushuaia', @idProvinciaTierraDelFuego),
('San Miguel de Tucum�n', @idProvinciaTucuman);

select distinct P.Nombre from Pais P join Provincia Prov on P.idPais = Prov.IdPais  

select * from DatosPersonales
delete from DatosPersonales where DNI = 34809874

select * from Paciente

EXEC CREATE PROCEDURE ListarHorariosProfesionalesConDatos
AS
BEGIN
    SELECT 
        p.Matricula,
        dp.Nombre,
        dp.Apellido,
        e.Nombre AS Especialidad,
        hp.DiaAtencion,
        hp.HoraInicio,
        hp.HoraFin
    FROM 
        Profesional p
    INNER JOIN 
        DatosPersonales dp ON p.DNI = dp.DNI
    INNER JOIN 
        Profesional_Especialidad pe ON p.Matricula = pe.Matricula
    INNER JOIN 
        Especialidad e ON pe.idEspecialidad = e.idEspecialidad
    INNER JOIN 
        HorariosProfesionales hp ON p.Matricula = hp.idMatricula
    WHERE 
        p.Activo = 1
    ORDER BY 
        p.Matricula, e.Nombre, hp.DiaAtencion, hp.HoraInicio;
END
GO

EXEC ListarHorariosProfesionalesConDatos;

CREATE  FUNCTION dbo.fn_CalcularEdadYTipoPaciente(@DNI INT)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        DP.Nombre,
        DP.Apellido,
        DATEDIFF(YEAR, DP.FechaNacimiento, GETDATE()) - 
            CASE 
                WHEN MONTH(DP.FechaNacimiento) > MONTH(GETDATE()) 
                     OR (MONTH(DP.FechaNacimiento) = MONTH(GETDATE()) AND DAY(DP.FechaNacimiento) > DAY(GETDATE())) 
                THEN 1 
                ELSE 0 
            END AS Edad,
        CASE 
            WHEN DATEDIFF(YEAR, DP.FechaNacimiento, GETDATE()) - 
                CASE 
                    WHEN MONTH(DP.FechaNacimiento) > MONTH(GETDATE()) 
                         OR (MONTH(DP.FechaNacimiento) = MONTH(GETDATE()) AND DAY(DP.FechaNacimiento) > DAY(GETDATE())) 
                    THEN 1 
                    ELSE 0 
                END < 16 
            THEN 'Paciente Pedi�trico'
            ELSE 'Paciente Adulto'
        END AS TipoPaciente
    FROM DatosPersonales DP
    WHERE DP.DNI = @DNI
);

select * from Paciente
select * from Paciente where dni = 45678901
select * from DatosPersonales where dni = 45678901

CREATE VIEW vw_PacientesConTipo
AS
SELECT 
    DP.DNI,
    DP.Nombre,
    DP.Apellido,
    DATEDIFF(YEAR, DP.FechaNacimiento, GETDATE()) - 
        CASE 
            WHEN MONTH(DP.FechaNacimiento) > MONTH(GETDATE()) 
                 OR (MONTH(DP.FechaNacimiento) = MONTH(GETDATE()) AND DAY(DP.FechaNacimiento) > DAY(GETDATE())) 
            THEN 1 
            ELSE 0 
        END AS Edad,
    CASE 
        WHEN DATEDIFF(YEAR, DP.FechaNacimiento, GETDATE()) - 
            CASE 
                WHEN MONTH(DP.FechaNacimiento) > MONTH(GETDATE()) 
                     OR (MONTH(DP.FechaNacimiento) = MONTH(GETDATE()) AND DAY(DP.FechaNacimiento) > DAY(GETDATE())) 
                THEN 1 
                ELSE 0 
            END < 16 
        THEN 'Paciente Pedi�trico'
        ELSE 'Paciente Adulto'
    END AS TipoPaciente
FROM DatosPersonales DP;

SELECT * FROM vw_PacientesConTipo;

select * from Turno

CREATE PROCEDURE SP_RecaudacionAnual
    @Anio INT
AS
BEGIN

    SELECT SUM(HonorarioConsulta) as RecaudacionAnual FROM Turno WHERE idEstadoTurno = 2
	AND YEAR(FechaTurno) = @Anio
END;