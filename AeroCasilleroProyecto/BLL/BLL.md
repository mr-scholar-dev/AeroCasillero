# Capa BLL del Sistema Aero-Casillero

## Objetivo
La capa BLL (Business Logic Layer) contiene las reglas de negocio del sistema. Su función es validar, procesar y coordinar la información antes de enviarla a la capa de acceso a datos o devolverla a la interfaz de usuario.

## Funciones principales

La BLL se encarga de:

- validar los datos recibidos desde la UI
- aplicar reglas del negocio
- controlar el flujo entre UI y DAL
- evitar que la interfaz acceda directamente a la base de datos
- mantener la lógica del sistema separada y fácil de mantener

## Servicios creados

### ClienteService
Administra las operaciones relacionadas con clientes.

Funciones:

- obtener todos los clientes
- buscar cliente por ID
- buscar cliente por documento
- crear cliente
- actualizar cliente
- eliminar cliente

Validaciones:

- nombres obligatorios
- apellidos obligatorios
- cédula o pasaporte obligatorio
- correo obligatorio
- teléfono obligatorio

### CasilleroService
Administra las operaciones relacionadas con casilleros.

Funciones:

- obtener todos los casilleros
- buscar casillero por ID
- buscar casillero por número
- crear casillero
- actualizar casillero
- eliminar casillero

Validaciones:

- número de casillero obligatorio
- ubicación obligatoria
- tamaño obligatorio
- estado obligatorio

### PaqueteService
Administra las operaciones relacionadas con paquetes.

Funciones:

- obtener todos los paquetes
- buscar paquete por ID
- buscar paquete por tracking
- crear paquete
- actualizar paquete
- eliminar paquete

Validaciones:

- tracking obligatorio
- peso mayor que cero
- dimensiones mayores que cero
- transportista obligatorio

## Relación con otras capas

### UI
La interfaz de usuario envía datos a la BLL para que sean revisados y procesados.

### DAL
La BLL llama a la DAL para guardar, consultar, editar o eliminar registros.

### DTO
La BLL recibe y devuelve DTO para manejar datos sin exponer directamente las entidades.

## Ejemplo simple

Cuando se registra un paquete:

1. La UI crea un `PaqueteDto`.
2. La BLL revisa si el tracking está vacío.
3. La BLL valida que el peso sea mayor que cero.
4. Si todo está correcto, la BLL llama a la DAL.
5. La DAL guarda el paquete.
6. La BLL devuelve el resultado a la UI.

## Resumen

La capa BLL es el centro de la lógica del sistema. Mantiene las reglas organizadas, evita duplicación de código y ayuda a que el proyecto sea fácil de mantener y extender.
