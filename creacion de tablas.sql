CREATE DATABASE PortLog

USE PortLog

CREATE TABLE PAIS(
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
CodPais varchar(2) NOT NULL unique,
NombrePais varchar(100) NOT NULL
)

CREATE TABLE USUARIO(
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
CI VARCHAR(8)NOT NULL UNIQUE,
PASS VARCHAR(60)NOT NULL,
ROL VARCHAR(20)NOT NULL
)


CREATE TABLE PERSONA(
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
RUT VARCHAR(60)NOT NULL UNIQUE,
NOMBRE VARCHAR(60)NOT NULL,
ANTIGUEDAD int NOT NULL
)

CREATE TABLE PRODUCTO(
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
CODIGO INT NOT NULL UNIQUE,
NOMBRE VARCHAR(60)NOT NULL,
PESO DECIMAL NOT NULL
)

CREATE TABLE IMPORTACION(
Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
FCHINGRESO DATETIME NOT NULL,
FCHSALIDA DATETIME NOT NULL,
PRODUCTOID INT NOT NULL,
CANTIDAD INT NOT NULL,
PERSONAID INT NOT NULL,
PAISID INT NOT NULL,
FOREIGN KEY (PAISID) REFERENCES Pais(Id),
FOREIGN KEY (PRODUCTOID) REFERENCES PRODUCTO(Id),
FOREIGN KEY (PERSONAID) REFERENCES PERSONA(Id)

)