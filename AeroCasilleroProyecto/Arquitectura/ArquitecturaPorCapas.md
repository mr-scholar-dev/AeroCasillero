# Arquitectura por Capas del Sistema Aero-Casillero

## Objetivo
El sistema Aero-Casillero fue organizado bajo una arquitectura por capas para separar responsabilidades, facilitar el mantenimiento y permitir que cada parte del proyecto cumpla una función específica.

## Capas del sistema

### UI
La capa UI contiene los formularios de Windows Forms.

Funciones:

- mostrar pantallas
- recibir datos del usuario
- enviar datos a la BLL
- mostrar resultados o mensajes

Formularios incluidos:

- `Form1`
- `PaqueteForm`
- `CasilleroForm`

### BLL
La capa BLL contiene la lógica de negocio.

Funciones:

- validar datos
- aplicar reglas del sistema
- coordinar el flujo entre UI y DAL

Servicios incluidos:

- `ClienteService`
- `CasilleroService`
- `PaqueteService`

### DAL
La capa DAL se encarga del acceso a datos.

Funciones:

- guardar información
- consultar registros
- actualizar datos
- eliminar registros

Repositorios incluidos:

- repositorios en memoria para pruebas
- repositorios SQL para conexión real

### Entities
Contiene las clases del dominio del sistema.

Ejemplos:

- `Cliente`
- `Casillero`
- `Paquete`
- `Envio`
- `Factura`
- `Usuario`

### DTO
Contiene objetos de transferencia de datos.

Función:

- mover datos entre capas sin exponer toda la lógica de negocio

### Interfaces
Contiene los contratos que definen el comportamiento de servicios y repositorios.

Función:

- permitir desacoplamiento
- facilitar cambios futuros
- cumplir con principios de diseño limpio

### Util
Contiene ayudas comunes utilizadas en varias capas.

Ejemplos:

- validaciones
- constantes
- conexión a base de datos
- mapeo entre entidades y DTO

## Flujo de trabajo

1. El usuario interactúa con la `UI`.
2. La `UI` envía un `DTO` a la `BLL`.
3. La `BLL` valida la información.
4. La `BLL` llama a la `DAL`.
5. La `DAL` guarda o consulta los datos.
6. La respuesta regresa a la `UI`.

## Ventajas de esta arquitectura

- mejora la organización del código
- reduce el acoplamiento entre partes
- facilita el mantenimiento
- permite probar cada capa por separado
- hace más fácil crecer el sistema en el futuro

## Relación con el proyecto

Esta arquitectura ayuda a cumplir con lo que pide el avance 1 porque demuestra una solución ordenada, escalable y pensada para trabajar con cliente WinForms y SQL Server.
