DROP DATABASE IF EXISTS bd_loquesea;
CREATE DATABASE bd_loquesea;
USE bd_loquesea;


CREATE TABLE Laboratorio (
Nombre VARCHAR (50) NOT NULL,
Ubicacion VARCHAR (50) NOT NULL,
idLaboratorio TINYINT UNSIGNED NOT NULL,
CONSTRAINT PK_Laboratorio PRIMARY KEY (idLaboratorio)
);


CREATE TABLE ModeloPc (
Marca VARCHAR (50) NOT NULL,
Modelo VARCHAR (50) NOT NULL,
Procesador VARCHAR (50) NOT NULL,
Ram SMALLINT UNSIGNED NOT NULL,
CONSTRAINT PK_ModeloPc PRIMARY KEY (modelo)
);


CREATE TABLE Computadora (
Nombre VARCHAR (50) NOT NULL,
SistemaOperativo VARCHAR (50) NOT NULL,
idLaboratorio INT NOT NULL,
Modelo VARCHAR (50) NOT NULL,
CONSTRAINT PK_Computadora PRIMARY KEY (nombre), 
CONSTRAINT FK_Computadora_Laboratorio
FOREIGN KEY (idLaboratorio)
REFERENCES Laboratorio(idLaboratorio),
CONSTRAINT FK_Computadora_Modelo 
FOREIGN KEY (modelo) 
REFERENCES ModeloPc(modelo)
);


CREATE TABLE Medicion (
id_Medicion INT (100) TINYINT UNSIGNED
Cpu INT (50)
Ram VARCHAR (50)
Temperatura TINYINT UNSIGNED NOT NULL,
Conectada BOOLEAN NOT NULL,
Fecha DATE NOT NULL,
CONSTRAINT PK_Medicion PRIMARY KEY (idMedicion), 
CONSTRAINT FK_Medicion_Computadora 
REFERENCES Computadora(nombre)
);
