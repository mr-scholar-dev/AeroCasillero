CREATE DATABASE AeroCasilleroProyecto;
GO

USE AeroCasilleroProyecto;
GO

CREATE TABLE Roles (
    RolId INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE,
    Descripcion NVARCHAR(200) NULL
);

CREATE TABLE Usuarios (
    UsuarioId INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario NVARCHAR(50) NOT NULL UNIQUE,
    Correo NVARCHAR(120) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    RolId INT NOT NULL,
    CONSTRAINT FK_Usuarios_Roles FOREIGN KEY (RolId) REFERENCES Roles(RolId)
);

CREATE TABLE Casilleros (
    CasilleroId INT IDENTITY(1,1) PRIMARY KEY,
    NumeroCasillero NVARCHAR(30) NOT NULL UNIQUE,
    Ubicacion NVARCHAR(100) NOT NULL,
    Tamano NVARCHAR(30) NOT NULL,
    Estado NVARCHAR(30) NOT NULL
);

CREATE TABLE Clientes (
    ClienteId INT IDENTITY(1,1) PRIMARY KEY,
    Nombres NVARCHAR(80) NOT NULL,
    Apellidos NVARCHAR(80) NOT NULL,
    CedulaPasaporte NVARCHAR(40) NOT NULL UNIQUE,
    Correo NVARCHAR(120) NOT NULL UNIQUE,
    Telefono NVARCHAR(30) NOT NULL,
    CasilleroId INT NOT NULL UNIQUE,
    CONSTRAINT FK_Clientes_Casilleros FOREIGN KEY (CasilleroId) REFERENCES Casilleros(CasilleroId)
);

CREATE TABLE Vuelos (
    VueloId INT IDENTITY(1,1) PRIMARY KEY,
    NumeroVuelo NVARCHAR(30) NOT NULL UNIQUE,
    Aerolinea NVARCHAR(100) NOT NULL,
    FechaSalida DATETIME2 NOT NULL,
    FechaLlegadaEstimada DATETIME2 NOT NULL,
    Origen NVARCHAR(100) NOT NULL,
    Destino NVARCHAR(100) NOT NULL
);

CREATE TABLE Tarifas (
    TarifaId INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(80) NOT NULL UNIQUE,
    MontoPorKg DECIMAL(18,2) NOT NULL,
    CobroMinimo DECIMAL(18,2) NOT NULL,
    Activa BIT NOT NULL DEFAULT 1
);

CREATE TABLE Impuestos (
    ImpuestoId INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(80) NOT NULL UNIQUE,
    Porcentaje DECIMAL(5,2) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1
);

CREATE TABLE Envios (
    EnvioId INT IDENTITY(1,1) PRIMARY KEY,
    CodigoEnvio NVARCHAR(40) NOT NULL UNIQUE,
    FechaCreacion DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    Estado NVARCHAR(30) NOT NULL,
    TipoEntrega NVARCHAR(30) NOT NULL,
    ClienteId INT NOT NULL,
    VueloId INT NULL,
    CONSTRAINT FK_Envios_Clientes FOREIGN KEY (ClienteId) REFERENCES Clientes(ClienteId),
    CONSTRAINT FK_Envios_Vuelos FOREIGN KEY (VueloId) REFERENCES Vuelos(VueloId)
);

CREATE TABLE Paquetes (
    PaqueteId INT IDENTITY(1,1) PRIMARY KEY,
    Tracking NVARCHAR(60) NOT NULL UNIQUE,
    Peso DECIMAL(18,2) NOT NULL,
    Alto DECIMAL(18,2) NOT NULL,
    Ancho DECIMAL(18,2) NOT NULL,
    Largo DECIMAL(18,2) NOT NULL,
    Transportista NVARCHAR(100) NOT NULL,
    FechaRecepcion DATETIME2 NOT NULL,
    Observaciones NVARCHAR(300) NULL,
    Estado NVARCHAR(30) NOT NULL,
    ClienteId INT NOT NULL,
    EnvioId INT NULL,
    UsuarioRecepcionId INT NULL,
    CONSTRAINT FK_Paquetes_Clientes FOREIGN KEY (ClienteId) REFERENCES Clientes(ClienteId),
    CONSTRAINT FK_Paquetes_Envios FOREIGN KEY (EnvioId) REFERENCES Envios(EnvioId),
    CONSTRAINT FK_Paquetes_Usuarios FOREIGN KEY (UsuarioRecepcionId) REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE Facturas (
    FacturaId INT IDENTITY(1,1) PRIMARY KEY,
    NumeroFactura NVARCHAR(40) NOT NULL UNIQUE,
    FechaEmision DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    Total DECIMAL(18,2) NOT NULL,
    EnvioId INT NOT NULL UNIQUE,
    CONSTRAINT FK_Facturas_Envios FOREIGN KEY (EnvioId) REFERENCES Envios(EnvioId)
);

CREATE TABLE Pagos (
    PagoId INT IDENTITY(1,1) PRIMARY KEY,
    FechaPago DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    Monto DECIMAL(18,2) NOT NULL,
    Metodo NVARCHAR(40) NOT NULL,
    Referencia NVARCHAR(60) NOT NULL,
    FacturaId INT NOT NULL,
    CONSTRAINT FK_Pagos_Facturas FOREIGN KEY (FacturaId) REFERENCES Facturas(FacturaId)
);

CREATE TABLE Bitacora (
    BitacoraId INT IDENTITY(1,1) PRIMARY KEY,
    FechaHora DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    Accion NVARCHAR(100) NOT NULL,
    Detalle NVARCHAR(400) NOT NULL,
    Usuario NVARCHAR(80) NULL
);

INSERT INTO Roles (Nombre, Descripcion) VALUES
('Administrador', 'Acceso total al sistema'),
('Supervisor', 'Supervisión operativa'),
('Operador', 'Registro y gestión operativa'),
('Consulta', 'Solo lectura');

INSERT INTO Casilleros (NumeroCasillero, Ubicacion, Tamano, Estado) VALUES
('CAS-001', 'Miami, FL', 'Mediano', 'Disponible'),
('CAS-002', 'Orlando, FL', 'Pequeño', 'Disponible');

INSERT INTO Clientes (Nombres, Apellidos, CedulaPasaporte, Correo, Telefono, CasilleroId) VALUES
('Juan', 'Pérez', 'P1234567', 'juan.perez@mail.com', '8888-1111', 1),
('María', 'López', 'P7654321', 'maria.lopez@mail.com', '8888-2222', 2);

INSERT INTO Tarifas (Nombre, MontoPorKg, CobroMinimo, Activa) VALUES
('Tarifa Estándar', 6.50, 15.00, 1);

INSERT INTO Impuestos (Nombre, Porcentaje, Activo) VALUES
('IVA', 13.00, 1),
('DAI', 10.00, 1);
