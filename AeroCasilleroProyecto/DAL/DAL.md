# Capa DAL del Sistema Aero-Casillero

## Objetivo
La capa DAL (Data Access Layer) es responsable de acceder a los datos del sistema. Su función es realizar operaciones de lectura, escritura, actualización y eliminación sobre la información almacenada.

## Funciones principales

La DAL se encarga de:

- guardar registros
- consultar registros
- actualizar información existente
- eliminar registros
- separar el acceso a datos de la lógica de negocio

## Repositorios creados

### InMemoryRepository<T>
Es una clase base genérica que almacena datos en memoria.

Sirve como base para los repositorios concretos y facilita que la lógica de acceso sea más simple y reutilizable.

### ClienteRepository
Administra los datos de clientes.

Funciones:

- obtener todos los clientes
- buscar cliente por ID
- buscar cliente por documento
- agregar cliente
- actualizar cliente
- eliminar cliente

### CasilleroRepository
Administra los datos de casilleros.

Funciones:

- obtener todos los casilleros
- buscar casillero por ID
- buscar casillero por número
- agregar casillero
- actualizar casillero
- eliminar casillero

### PaqueteRepository
Administra los datos de paquetes.

Funciones:

- obtener todos los paquetes
- buscar paquete por ID
- buscar paquete por tracking
- agregar paquete
- actualizar paquete
- eliminar paquete

## Relación con otras capas

### BLL
La BLL llama a la DAL para guardar o consultar datos después de validar la información.

### DTO
La DAL trabaja con DTO para transportar información de forma simple.

### UI
La interfaz no debe acceder directamente a la DAL. Debe pasar por la BLL.

## Ejemplo simple

Cuando la BLL quiere guardar un cliente:

1. Recibe un `ClienteDto`.
2. Llama a `ClienteRepository`.
3. El repositorio asigna un ID.
4. El dato queda guardado en memoria.
5. La respuesta vuelve a la BLL.

## Resumen

La capa DAL mantiene separada la lógica de acceso a datos. Esto hace que el sistema sea más ordenado, fácil de mantener y preparado para cambiar la forma de almacenamiento en el futuro, por ejemplo de memoria a SQL Server.
