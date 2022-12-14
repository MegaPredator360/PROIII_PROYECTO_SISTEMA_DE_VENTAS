CREATE DATABASE FRESH_SUPERMARKET
GO

USE FRESH_SUPERMARKET

CREATE TABLE CLIENTES (
CLIE_ID INT NOT NULL,
CLIE_NOMBRE VARCHAR(100) NOT NULL,
CLIE_CORREO VARCHAR(100) NOT NULL,
CLIE_TELEFONO INT,
CLIE_DIRECCION VARCHAR(100),
CONSTRAINT PK_CLIENTES PRIMARY KEY (CLIE_ID)
)

INSERT INTO CLIENTES VALUES (0, 'Cliente Contado', 'freshsupermaket@outlook.com', 0, 0)
SELECT * FROM CLIENTES

CREATE TABLE EMPLEADOS (
EMPL_ID INT NOT NULL,
EMPL_NOMBRE VARCHAR(100) NOT NULL,
EMPL_CORREO VARCHAR(100) NOT NULL,
EMPL_USUARIO VARCHAR(100) NOT NULL,
EMPL_CONTRASENA VARCHAR(100) NOT NULL,
EMPL_TIPO_USUARIO VARCHAR(100),
CONSTRAINT PK_EMPLEADOS PRIMARY KEY (EMPL_ID)
)

INSERT INTO EMPLEADOS VALUES (205540164, 'James McIntosh Molina', 'jamesmcintoshmolina@gmail.com', 'admin', '1234', 'Administrador')
SELECT * FROM EMPLEADOS

CREATE TABLE PROVEEDORES (
PROV_ID INT NOT NULL,
PROV_NOMBRE VARCHAR(100) NOT NULL,
PROV_CORREO VARCHAR(100) NOT NULL,
PROV_TELEFONO INT NOT NULL,
PROV_DIRECCION VARCHAR(100) NOT NULL,
CONSTRAINT PK_PROVEEDORES PRIMARY KEY (PROV_ID)
)

INSERT INTO PROVEEDORES VALUES (310518912, 'Dipo S.A', 'dipo@hotmail.com', 24489876, 'Heredia')
SELECT * FROM PROVEEDORES

CREATE TABLE PRODUCTOS (
PROD_ID INT NOT NULL,
PROD_NOMBRE VARCHAR(100) NOT NULL,
PROD_DESCRIPCION VARCHAR(100) NOT NULL,
PROD_CANTIDAD INT NOT NULL,
PROD_PRECIO INT NOT NULL,
CONSTRAINT PK_PRODUCTOS PRIMARY KEY (PROD_ID)
)

INSERT INTO PRODUCTOS VALUES (10001, 'Arroz Sabemas 2K', 'Bolsa de Arroz blanco de 2K', 25, 12000)
SELECT * FROM PRODUCTOS

CREATE TABLE FACTURAS (
FACT_ID INT NOT NULL,
FACT_CLIE_ID INT NOT NULL,
FACT_EMPL_ID INT NOT NULL,
FACT_FECHA DATETIME NOT NULL,
FACT_SUBTOTAL INT NOT NULL,
FACT_DESCUENTO INT NOT NULL,
FACT_TOTAL INT NOT NULL,
FACT_METODO_PAGO VARCHAR(10) NOT NULL,
FACT_PAGO INT NOT NULL,
FACT_VUELTO INT NOT NULL,
CONSTRAINT PK_FACTURAS PRIMARY KEY (FACT_ID),
CONSTRAINT FK_FACTURAS_CLIENTES FOREIGN KEY (FACT_CLIE_ID) REFERENCES CLIENTES(CLIE_ID),
CONSTRAINT FK_FACTURAS_EMPLEADOS FOREIGN KEY (FACT_EMPL_ID) REFERENCES EMPLEADOS(EMPL_ID)
)

INSERT INTO FACTURAS VALUES (1, 0, 205540164, GETDATE(), 12000, 0, 12000, 'Efectivo', 12000, 0)
SELECT * FROM FACTURAS

CREATE TABLE DETALLE_FACTURA (
DEFA_ID INT IDENTITY(1,1) NOT NULL,
DEFA_FACT_ID INT NOT NULL,
DEFA_PROD_ID INT NOT NULL,
DEFA_CANTIDAD INT NOT NULL,
DEFA_TOTAL INT NOT NULL,
CONSTRAINT PK_DETAFACT PRIMARY KEY (DEFA_ID),
CONSTRAINT FK_DETAFACT_PRODUCTOS FOREIGN KEY (DEFA_PROD_ID) REFERENCES PRODUCTOS(PROD_ID)
)

INSERT INTO DETALLE_FACTURA VALUES (1, 10001, 2, 12000)
SELECT * FROM DETALLE_FACTURA

-- Procedimientos Almacenados / Stored Procedures

CREATE PROCEDURE SP_INSERT_FACTURA(
@FACT_ID INT,
@CLIE_NOMBRE VARCHAR(100),
@EMPL_NOMBRE VARCHAR(100),
@SUBTOTAL INT,
@DESCUENTO INT,
@TOTAL INT,
@METODO_PAGO VARCHAR(10),
@PAGO INT,
@VUELTO INT
)
AS
BEGIN
DECLARE @CLIE_ID INT
SET @CLIE_ID = (SELECT CLIE_ID FROM CLIENTES WHERE CLIE_NOMBRE = @CLIE_NOMBRE)
DECLARE @EMPL_ID INT
SET @EMPL_ID = (SELECT EMPL_ID FROM EMPLEADOS WHERE EMPL_NOMBRE = @EMPL_NOMBRE)
INSERT INTO FACTURAS VALUES (	@FACT_ID,	@CLIE_ID,	@EMPL_ID,	GETDATE(),	@SUBTOTAL,	@DESCUENTO,	@TOTAL,	@METODO_PAGO,	@PAGO,	@VUELTO)
END

CREATE PROCEDURE SP_INSERT_DEFA_COD(
@FACT_ID INT,
@PROD_ID INT,
@CANTIDAD INT
)
AS
BEGIN
DECLARE @TOTAL INT
SET @TOTAL = (SELECT PROD_PRECIO * @CANTIDAD FROM PRODUCTOS WHERE PROD_ID = @PROD_ID)
INSERT INTO DETALLE_FACTURA(	DEFA_FACT_ID,	DEFA_PROD_ID,	DEFA_CANTIDAD,	DEFA_TOTAL)
VALUES(							@FACT_ID,		@PROD_ID,		@CANTIDAD,		@TOTAL)
UPDATE PRODUCTOS SET PROD_CANTIDAD = PROD_CANTIDAD - @CANTIDAD WHERE PROD_ID = @PROD_ID
END

CREATE PROCEDURE SP_INSERT_DEFA_NOM(
@FACT_ID INT,
@PROD_NOMBRE VARCHAR(100),
@CANTIDAD INT
)
AS
BEGIN
DECLARE @PROD_ID INT
DECLARE @TOTAL INT
SET @PROD_ID = (SELECT PROD_ID FROM PRODUCTOS WHERE PROD_NOMBRE = @PROD_NOMBRE)
SET @TOTAL = (SELECT PROD_PRECIO * @CANTIDAD FROM PRODUCTOS WHERE PROD_ID = @PROD_ID)
INSERT INTO DETALLE_FACTURA(	DEFA_FACT_ID,	DEFA_PROD_ID,	DEFA_CANTIDAD,	DEFA_TOTAL)
VALUES(							@FACT_ID,		@PROD_ID,		@CANTIDAD,		@TOTAL)
UPDATE PRODUCTOS SET PROD_CANTIDAD = PROD_CANTIDAD - @CANTIDAD WHERE PROD_ID = @PROD_ID
END

CREATE PROCEDURE SP_DELETE_DEFA(
@FACT_ID INT,
@PROD_ID INT
)
AS
BEGIN
DECLARE @CANTIDAD INT
SET @CANTIDAD = (SELECT DEFA_CANTIDAD FROM DETALLE_FACTURA WHERE DEFA_FACT_ID = @FACT_ID AND DEFA_PROD_ID = @PROD_ID)
UPDATE PRODUCTOS SET PROD_CANTIDAD = PROD_CANTIDAD + @CANTIDAD WHERE PROD_ID = @PROD_ID
DELETE DETALLE_FACTURA WHERE DEFA_FACT_ID = @FACT_ID AND DEFA_PROD_ID = @PROD_ID
END

CREATE PROCEDURE SP_DEVOLUCION(
@FACT_ID INT,
@PROD_NOMBRE VARCHAR(100),
@CANT_DEVOLVER INT
)
AS
BEGIN
DECLARE @PROD_ID INT
DECLARE @PROD_TOTAL INT
SET @PROD_ID = (SELECT PROD_ID FROM PRODUCTOS WHERE PROD_NOMBRE = @PROD_NOMBRE)
SET @PROD_TOTAL = (SELECT PROD_PRECIO * @CANT_DEVOLVER FROM PRODUCTOS WHERE PROD_ID = @PROD_ID)
UPDATE DETALLE_FACTURA SET DEFA_CANTIDAD = (DEFA_CANTIDAD - @CANT_DEVOLVER), DEFA_TOTAL = (DEFA_TOTAL - @PROD_TOTAL) WHERE DEFA_FACT_ID = @FACT_ID AND DEFA_PROD_ID = @PROD_ID
UPDATE FACTURAS SET FACT_SUBTOTAL = (FACT_SUBTOTAL - @PROD_TOTAL), FACT_TOTAL = (FACT_TOTAL - @PROD_TOTAL), FACT_VUELTO = (FACT_VUELTO + @PROD_TOTAL) WHERE FACT_ID = @FACT_ID
UPDATE PRODUCTOS SET PROD_CANTIDAD = (PROD_CANTIDAD + @CANT_DEVOLVER) WHERE PROD_ID = @PROD_ID
END