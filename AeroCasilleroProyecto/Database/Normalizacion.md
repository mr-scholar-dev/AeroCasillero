# Normalización de la Base de Datos

## Objetivo
La propuesta de base de datos para el sistema Aero-Casillero Internacional fue diseñada para cumplir con la Primera, Segunda y Tercera Forma Normal, evitando redundancia, anomalías de inserción, actualización y eliminación, y garantizando integridad referencial.

## 1FN - Primera Forma Normal

La base de datos cumple con la Primera Forma Normal porque:

- Cada tabla posee una clave primaria única.
- Todos los campos contienen valores atómicos.
- No existen listas, grupos repetitivos ni múltiples valores en una sola celda.

### Ejemplos

- En `Clientes`, los datos del cliente están separados en campos independientes: nombres, apellidos, correo y teléfono.
- En `Paquetes`, el tracking, peso, dimensiones y transportista están en columnas distintas.
- En `Facturas`, el número de factura y el total están almacenados en atributos separados.

## 2FN - Segunda Forma Normal

La base de datos cumple con la Segunda Forma Normal porque:

- Todas las tablas cumplen con 1FN.
- Los atributos no clave dependen completamente de la clave primaria.
- No existen dependencias parciales, ya que las claves primarias son simples en las tablas principales.

### Ejemplos

- En `Paquetes`, todos los campos descriptivos dependen únicamente de `PaqueteId`.
- En `Envios`, los atributos `Estado`, `TipoEntrega` y `FechaCreacion` dependen únicamente de `EnvioId`.
- En `Facturas`, `NumeroFactura`, `FechaEmision` y `Total` dependen de `FacturaId`.

## 3FN - Tercera Forma Normal

La base de datos cumple con la Tercera Forma Normal porque:

- Todas las tablas cumplen con 2FN.
- No existen dependencias transitivas entre atributos no clave.
- La información dependiente de catálogos o relaciones se separó en tablas independientes.

### Ejemplos

- `Roles` se almacena en una tabla independiente para evitar repetir nombres de rol en `Usuarios`.
- `Casilleros` se maneja aparte de `Clientes`, evitando repetir la información del casillero por cada cliente.
- `Tarifas` e `Impuestos` se mantienen como entidades separadas para facilitar cambios y evitar redundancia.

## Justificación de la estructura

La separación de entidades permite:

- reducir redundancia de datos,
- mejorar el mantenimiento,
- facilitar la consulta y actualización,
- y sostener la escalabilidad del sistema.

Además, esta estructura favorece la implementación de la arquitectura por capas, la reutilización de datos en DTO y la claridad en el modelo relacional.
