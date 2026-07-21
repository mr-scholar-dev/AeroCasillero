# Modelo Relacional

## Tablas principales y relaciones

- `Roles` 1 ---- n `Usuarios`
- `Casilleros` 1 ---- 1 `Clientes`
- `Clientes` 1 ---- n `Paquetes`
- `Clientes` 1 ---- n `Envios`
- `Vuelos` 1 ---- n `Envios`
- `Envios` 1 ---- n `Paquetes`
- `Envios` 1 ---- 1 `Facturas`
- `Facturas` 1 ---- n `Pagos`
- `Usuarios` 1 ---- n `Paquetes` como usuario receptor

## Descripción de relaciones

### Roles - Usuarios
Un rol puede estar asignado a muchos usuarios, pero cada usuario pertenece a un solo rol.

### Casilleros - Clientes
Cada cliente posee un casillero asignado de forma única.

### Clientes - Paquetes
Un cliente puede recibir varios paquetes.

### Clientes - Envios
Un cliente puede tener varios envíos.

### Vuelos - Envios
Un vuelo puede transportar varios envíos.

### Envios - Paquetes
Un envío puede agrupar varios paquetes.

### Envios - Facturas
Cada envío genera una sola factura.

### Facturas - Pagos
Una factura puede tener uno o varios pagos.

### Usuarios - Paquetes
Un usuario operativo puede registrar la recepción de muchos paquetes.
