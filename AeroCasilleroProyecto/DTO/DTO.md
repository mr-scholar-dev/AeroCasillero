# DTO del Sistema Aero-Casillero

## Objetivo
Las clases DTO (Data Transfer Object) se utilizan para transportar información entre la interfaz de usuario, la lógica de negocio y el acceso a datos, sin exponer directamente las entidades del dominio.

## Función principal

Las DTO cumplen estas funciones:

- trasladar datos de forma simple entre capas
- evitar el acoplamiento directo con las entidades
- mostrar solo la información necesaria en pantalla
- facilitar el mantenimiento del sistema
- apoyar la arquitectura por capas

## DTO creados en el proyecto

### ClienteDto
Contiene los datos necesarios para registrar, consultar o editar un cliente.

### CasilleroDto
Contiene la información del casillero, como número, ubicación, tamaño y estado.

### PaqueteDto
Contiene la información del paquete recibido, incluyendo tracking, peso, dimensiones, estado y relación con el cliente.

### EnvioDto
Contiene los datos del envío consolidado o preparado para salida.

### VueloDto
Contiene los datos de programación de vuelos.

### TarifaDto
Contiene la información de tarifas por kilogramo y cobro mínimo.

### ImpuestoDto
Contiene la información de impuestos aplicables como IVA o DAI.

### FacturaDto
Contiene los datos de la factura generada para un envío.

### PagoDto
Contiene la información de los pagos registrados.

### RolDto
Contiene la información de los roles del sistema.

### UsuarioDto
Contiene los datos básicos del usuario y su rol asignado.

### BitacoraDto
Contiene los registros de auditoría del sistema.

## Ejemplo de uso

Cuando el usuario registra un paquete en la interfaz:

1. La pantalla crea un `PaqueteDto`.
2. La capa BLL valida la información.
3. La capa DAL guarda los datos.
4. La respuesta vuelve como otro `PaqueteDto` o como un resultado de operación.

## Resumen

Las DTO funcionan como "paquetes de datos" que viajan entre capas. Su propósito es mantener el sistema ordenado, fácil de mantener y alineado con la arquitectura N-capas.
