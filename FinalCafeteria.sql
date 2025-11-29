CREATE DATABASE LabCafeteria;
GO
USE [master]
GO
CREATE LOGIN [usrcafeteria] WITH PASSWORD = N'123456',
	DEFAULT_DATABASE = [LabCafeteria],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [LabCafeteria]
GO
CREATE USER [usrcafeteria] FOR LOGIN [usrcafeteria]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrcafeteria]
GO

DROP TABLE DetallePedido;
DROP TABLE Pedido;
DROP TABLE Usuario;
DROP TABLE Empleado;
DROP TABLE Cliente;
DROP TABLE Producto;
DROP TABLE Categoria;
DROP PROC paPedidoListar;
DROP PROC paClienteListar;
DROP PROC paProductoListar;
DROP PROC paEmpleadoListar;

CREATE TABLE Categoria (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL UNIQUE,
    estado SMALLINT NOT NULL DEFAULT 1
);

CREATE TABLE Producto (
    id INT PRIMARY KEY IDENTITY(1,1),
    idCategoria INT NOT NULL,
    codigo VARCHAR(20) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(250),
    saldo DECIMAL NOT NULL DEFAULT 0,
    precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0),
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Producto_Categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(id)
);


CREATE TABLE Cliente (
    id INT PRIMARY KEY IDENTITY(1,1),
    cedulaIdentidad VARCHAR(12) NOT NULL,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
);

CREATE TABLE Empleado (
    id INT PRIMARY KEY IDENTITY(1,1),
    cedulaIdentidad VARCHAR(12) NOT NULL,
    nombres VARCHAR(30) NOT NULL,
    primerApellido VARCHAR(30) NULL,
    segundoApellido VARCHAR(30) NULL,
    direccion VARCHAR(250) NOT NULL,
    celular BIGINT NOT NULL,
    cargo VARCHAR(50) NOT NULL,  -- Ej: "Cajero", "Barista" etc se agregaran en una opcion cbx en windowns forms
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
);


CREATE TABLE Usuario (
    id INT PRIMARY KEY IDENTITY(1,1),
    idEmpleado INT NOT NULL, 
    usuario VARCHAR(50) UNIQUE NOT NULL,
    clave VARCHAR(255) NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);

CREATE TABLE Pedido (
    id INT PRIMARY KEY IDENTITY(1,1),
    idUsuario INT NOT NULL,
    idCliente INT NOT NULL,
    numeroTransaccion AS 'PED-' + CAST(id AS VARCHAR(10)),
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_Venta_Usuario FOREIGN KEY(idUsuario) REFERENCES Usuario(id),
    CONSTRAINT fk_Venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id),
);

CREATE TABLE DetallePedido (
    id INT PRIMARY KEY IDENTITY(1,1),
    idPedido INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL,
    precioUnitario DECIMAL NOT NULL,
    total DECIMAL NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_DetallePedido_Pedido FOREIGN KEY(idPedido) REFERENCES Pedido(id),
    CONSTRAINT fk_DetallePedido_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);

GO
ALTER TABLE Producto ADD imagenUrl VARCHAR(300) NULL;
GO


GO
CREATE PROC paPedidoListar @parametro VARCHAR(100)
AS
  SELECT p.id, p.numeroTransaccion, c.nombres + ' ' + c.apellidos AS Cliente, 
         u.usuario AS Usuario, p.fechaRegistro, p.estado
  FROM Pedido p
  INNER JOIN Cliente c ON c.id = p.idCliente
  INNER JOIN Usuario u ON u.id = p.idUsuario
  WHERE p.estado<>-1 
    AND (c.nombres + c.apellidos + u.usuario + p.numeroTransaccion) LIKE '%'+REPLACE(@parametro,' ','%')+'%'
  ORDER BY p.fechaRegistro DESC;

GO
CREATE PROC paClienteListar @parametro VARCHAR(100)
AS
  SELECT c.id, c.cedulaIdentidad, c.nombres, c.apellidos, 
         c.usuarioRegistro, c.fechaRegistro, c.estado
  FROM Cliente c
  WHERE c.estado<>-1 
    AND (c.cedulaIdentidad + c.nombres + c.apellidos) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
  ORDER BY c.nombres, c.apellidos;

GO
CREATE PROC paProductoListar @parametro VARCHAR(100)
AS
  SELECT p.id, p.codigo,p.nombre, p.descripcion, ca.nombre AS Categoria, p.saldo, p.precioVenta,
		 p.usuarioRegistro, p.fechaRegistro, p.estado, p.idCategoria
  FROM Producto p
  INNER JOIN Categoria ca ON ca.id = p.idCategoria
  WHERE p.estado<>-1 AND p.nombre+p.codigo+p.descripcion+ca.nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%'
  ORDER BY p.estado DESC, p.descripcion ASC;


GO
CREATE PROC paEmpleadoListar @parametro VARCHAR(50)
AS
  SELECT e.id, e.cedulaIdentidad, nombres, ISNULL(e.primerApellido,'') AS primerApellido, 
		 ISNULL(e.segundoApellido, '') AS segundoApellido, e.direccion, e.celular, e.cargo,
		 ISNULL(e.usuarioRegistro, '') AS usuarioRegistro, ISNULL(e.fechaRegistro,GETDATE()) AS fechaRegistro, 
		 ISNULL(u.id,0) as idUsuario, ISNULL(u.usuario, '') as usuario,
         e.estado
  FROM Empleado e
  LEFT JOIN Usuario u ON e.id = u.idEmpleado
  WHERE e.estado<>-1 
		AND e.cedulaIdentidad+e.nombres+e.primerApellido+e.segundoApellido LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY e.nombres,e.primerApellido;

-- DML

--Empleados
INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('1234567', 'Marlene', 'Cruz', 'Villca', 'Plaza', 654654654, 'Administrador');

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('1234567', 'Soledad', 'Zegarra', 'A.', 'Centro', 9876543, 'Administrador');

-- clave "hola123"
INSERT INTO Usuario(idEmpleado,usuario,clave)
VALUES (1, 'marle', 'i0hcoO/nssY6WOs9pOp5Xw==');

INSERT INTO Usuario(idEmpleado,usuario,clave)
VALUES (2, 'sole', 'i0hcoO/nssY6WOs9pOp5Xw==');

SELECT * FROM Usuario;

