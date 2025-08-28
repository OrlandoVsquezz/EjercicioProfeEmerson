CREATE DATABASE Zapatos20250273;
GO
USE Zapatos20250273;
GO
 
CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL
);
 

CREATE TABLE Zapatos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CategoriaId INT FOREIGN KEY REFERENCES Categorias(Id) ON DELETE CASCADE,
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    ImagenURL NVARCHAR(255),
    FechaCreacion DATETIME DEFAULT GETDATE()
);
 
CREATE TABLE Tallas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ZapatoId INT FOREIGN KEY REFERENCES Zapatos(Id) ON DELETE CASCADE,
    Talla NVARCHAR(10) NOT NULL, 
    Cantidad INT DEFAULT 0,
    CONSTRAINT UQ_ZapatoTalla UNIQUE (ZapatoId, Talla)
);

 CREATE TABLE Roles (
 	Id INT PRIMARY KEY IDENTITY,
 	Nombre NVARCHAR(50) UNIQUE NOT NULL
 );
 GO

 CREATE TABLE Usuarios (
 	Id INT PRIMARY KEY IDENTITY,
 	Nombre NVARCHAR(100),
 	Email NVARCHAR(100) UNIQUE,
 	clave NVARCHAR(255),
 	RolId INT,
 	FOREIGN KEY (RolId) REFERENCES Roles(Id)
 );
 GO
 
 INSERT INTO Roles (Nombre)
 VALUES ('Administrador'), ('Empleado');
 
INSERT INTO Categorias (Nombre)
VALUES 
('Deportivos'),
('Formales');
GO
 
INSERT INTO Zapatos (CategoriaId, Nombre, Precio, ImagenURL)
VALUES 
(1, 'Zapato Running Pro', 89.99, '/imagenes/running-pro.jpg'), 
(2, 'Zapato Oxford Clásico', 120.50, '/imagenes/oxford-clasico.jpg');  
GO
 
INSERT INTO Tallas (ZapatoId, Talla, Cantidad)
VALUES 
(1, '38', 5),
(1, '39', 8);
GO

INSERT INTO Tallas (ZapatoId, Talla, Cantidad)
VALUES 
(2, '40', 3),
(2, '41', 6);
GO
 
select * from Zapatos;
select *from Roles;
select * from Usuarios;
 
CREATE VIEW vistaCategoria AS
SELECT Z.Id AS [N° de Registro], Z.Nombre, Z.Precio, Z.ImagenURL, C.Nombre AS Categoria FROM Zapatos Z
INNER JOIN 
Categorias C ON Z.CategoriaId = C.Id