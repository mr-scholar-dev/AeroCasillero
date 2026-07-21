# Diccionario de Datos

## Tabla: Roles

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| RolId | INT | PK | No | IDENTITY(1,1) | Identificador único del rol. |
| Nombre | NVARCHAR(50) | - | No | - | Nombre del rol dentro del sistema. |
| Descripcion | NVARCHAR(200) | - | Sí | NULL | Descripción breve del rol. |

## Tabla: Usuarios

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| UsuarioId | INT | PK | No | IDENTITY(1,1) | Identificador único del usuario. |
| NombreUsuario | NVARCHAR(50) | - | No | - | Nombre de acceso del usuario. |
| Correo | NVARCHAR(120) | - | No | - | Correo electrónico del usuario. |
| PasswordHash | NVARCHAR(255) | - | No | - | Contraseña cifrada o hash. |
| Activo | BIT | - | No | 1 | Indica si el usuario está activo. |
| RolId | INT | FK [Roles] | No | - | Rol asignado al usuario. |

## Tabla: Casilleros

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| CasilleroId | INT | PK | No | IDENTITY(1,1) | Identificador único del casillero. |
| NumeroCasillero | NVARCHAR(30) | - | No | - | Número único del casillero. |
| Ubicacion | NVARCHAR(100) | - | No | - | Ubicación física del casillero. |
| Tamano | NVARCHAR(30) | - | No | - | Tamaño del casillero. |
| Estado | NVARCHAR(30) | - | No | - | Estado actual del casillero. |

## Tabla: Clientes

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| ClienteId | INT | PK | No | IDENTITY(1,1) | Identificador único del cliente. |
| Nombres | NVARCHAR(80) | - | No | - | Nombres del cliente. |
| Apellidos | NVARCHAR(80) | - | No | - | Apellidos del cliente. |
| CedulaPasaporte | NVARCHAR(40) | - | No | - | Identificación oficial del cliente. |
| Correo | NVARCHAR(120) | - | No | - | Correo electrónico del cliente. |
| Telefono | NVARCHAR(30) | - | No | - | Número telefónico del cliente. |
| CasilleroId | INT | FK [Casilleros] | No | - | Casillero asignado al cliente. |

## Tabla: Vuelos

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| VueloId | INT | PK | No | IDENTITY(1,1) | Identificador único del vuelo. |
| NumeroVuelo | NVARCHAR(30) | - | No | - | Código o número del vuelo. |
| Aerolinea | NVARCHAR(100) | - | No | - | Nombre de la aerolínea. |
| FechaSalida | DATETIME2 | - | No | - | Fecha y hora de salida. |
| FechaLlegadaEstimada | DATETIME2 | - | No | - | Fecha y hora estimada de llegada. |
| Origen | NVARCHAR(100) | - | No | - | Ciudad o aeropuerto de origen. |
| Destino | NVARCHAR(100) | - | No | - | Ciudad o aeropuerto de destino. |

## Tabla: Tarifas

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| TarifaId | INT | PK | No | IDENTITY(1,1) | Identificador único de la tarifa. |
| Nombre | NVARCHAR(80) | - | No | - | Nombre de la tarifa. |
| MontoPorKg | DECIMAL(18,2) | - | No | - | Precio por kilogramo. |
| CobroMinimo | DECIMAL(18,2) | - | No | - | Cobro mínimo aplicable. |
| Activa | BIT | - | No | 1 | Indica si la tarifa está vigente. |

## Tabla: Impuestos

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| ImpuestoId | INT | PK | No | IDENTITY(1,1) | Identificador único del impuesto. |
| Nombre | NVARCHAR(80) | - | No | - | Nombre del impuesto. |
| Porcentaje | DECIMAL(5,2) | - | No | - | Porcentaje del impuesto. |
| Activo | BIT | - | No | 1 | Indica si el impuesto está vigente. |

## Tabla: Envios

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| EnvioId | INT | PK | No | IDENTITY(1,1) | Identificador único del envío. |
| CodigoEnvio | NVARCHAR(40) | - | No | - | Código del envío. |
| FechaCreacion | DATETIME2 | - | No | SYSDATETIME() | Fecha de creación del envío. |
| Estado | NVARCHAR(30) | - | No | - | Estado actual del envío. |
| TipoEntrega | NVARCHAR(30) | - | No | - | Método de entrega seleccionado. |
| ClienteId | INT | FK [Clientes] | No | - | Cliente propietario del envío. |
| VueloId | INT | FK [Vuelos] | Sí | NULL | Vuelo asociado al envío. |

## Tabla: Paquetes

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| PaqueteId | INT | PK | No | IDENTITY(1,1) | Identificador único del paquete. |
| Tracking | NVARCHAR(60) | - | No | - | Número de seguimiento del paquete. |
| Peso | DECIMAL(18,2) | - | No | - | Peso del paquete. |
| Alto | DECIMAL(18,2) | - | No | - | Alto del paquete. |
| Ancho | DECIMAL(18,2) | - | No | - | Ancho del paquete. |
| Largo | DECIMAL(18,2) | - | No | - | Largo del paquete. |
| Transportista | NVARCHAR(100) | - | No | - | Empresa transportista. |
| FechaRecepcion | DATETIME2 | - | No | - | Fecha y hora de recepción. |
| Observaciones | NVARCHAR(300) | - | Sí | NULL | Observaciones adicionales. |
| Estado | NVARCHAR(30) | - | No | - | Estado actual del paquete. |
| ClienteId | INT | FK [Clientes] | No | - | Cliente asociado al paquete. |
| EnvioId | INT | FK [Envios] | Sí | NULL | Envío al que pertenece el paquete. |
| UsuarioRecepcionId | INT | FK [Usuarios] | Sí | NULL | Usuario que registró la recepción. |

## Tabla: Facturas

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| FacturaId | INT | PK | No | IDENTITY(1,1) | Identificador único de la factura. |
| NumeroFactura | NVARCHAR(40) | - | No | - | Número de la factura. |
| FechaEmision | DATETIME2 | - | No | SYSDATETIME() | Fecha de emisión. |
| Total | DECIMAL(18,2) | - | No | - | Total a pagar. |
| EnvioId | INT | FK [Envios] | No | - | Envío facturado. |

## Tabla: Pagos

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| PagoId | INT | PK | No | IDENTITY(1,1) | Identificador único del pago. |
| FechaPago | DATETIME2 | - | No | SYSDATETIME() | Fecha y hora del pago. |
| Monto | DECIMAL(18,2) | - | No | - | Monto pagado. |
| Metodo | NVARCHAR(40) | - | No | - | Método de pago. |
| Referencia | NVARCHAR(60) | - | No | - | Número o referencia de pago. |
| FacturaId | INT | FK [Facturas] | No | - | Factura asociada al pago. |

## Tabla: Bitacora

| Campo | Tipo Dato / Tamaño | PK / FK [Tabla] | ¿Null? | Valor Defecto | Descripción |
|---|---|---|---|---|---|
| BitacoraId | INT | PK | No | IDENTITY(1,1) | Identificador único del registro de bitácora. |
| FechaHora | DATETIME2 | - | No | SYSDATETIME() | Fecha y hora del evento. |
| Accion | NVARCHAR(100) | - | No | - | Acción realizada. |
| Detalle | NVARCHAR(400) | - | No | - | Descripción del evento. |
| Usuario | NVARCHAR(80) | - | Sí | NULL | Usuario que ejecutó la acción. |
