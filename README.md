# AeroCasilleroProyecto

Sistema WinForms para la gestión de un aero-casillero internacional, enfocado en el registro de casilleros, recepción de paquetes, control de trazabilidad y base para cálculo de costos, facturación y entrega.

## De qué trata el proyecto

Este proyecto fue desarrollado para el curso ISW-524 Diseño de Arquitectura de Software como un avance de análisis, diseño y estructura técnica.

La solución está organizada con arquitectura por capas:

- `UI`: formularios WinForms
- `BLL`: lógica de negocio
- `DAL`: acceso a datos
- `Entities`: entidades del dominio
- `DTO`: objetos de transferencia de datos
- `Interfaces`: contratos de repositorios y servicios
- `Util`: utilidades comunes, conexión y ayudas técnicas

## Qué incluye

- formulario principal de clientes
- formulario de paquetes
- formulario de casilleros
- entidades base del negocio
- DTOs para transporte de datos
- servicios de negocio
- repositorios en memoria y SQL
- script inicial de base de datos
- documentación de arquitectura y base de datos

## Requisitos

- Visual Studio 2022
- .NET 10 Windows Forms
- SQL Server para ejecutar el script de base de datos

## Cómo abrir el proyecto

1. Abre la solución `AeroCasilleroProyecto.slnx` en Visual Studio.
2. Ejecuta el proyecto WinForms.
3. Si deseas usar la base de datos real, ejecuta antes el script:
   - `AeroCasilleroProyecto/Database/AeroCasilleroProyecto.sql`

## Cómo volver a subirlo después a GitLab

Si más adelante descargan el proyecto en un `.zip` y lo quieren volver a subir a GitLab, pueden seguir esta guía rápida:

### 1. Descomprimir el zip

- Extraigan el `.zip` en una carpeta local, por ejemplo:
  - `C:\Proyectos\AeroCasilleroProyecto`

### 2. Abrir la carpeta del proyecto

- Verifiquen que dentro exista la solución:
  - `AeroCasilleroProyecto.slnx`

### 3. Abrir una terminal en esa carpeta

- Desde la carpeta raíz del proyecto:
  - `git init`
  - `git add .`
  - `git commit -m "Initial import of AeroCasillero project"`

### 4. Crear el repositorio en GitLab

- En GitLab, creen un proyecto nuevo vacío.
- Copien la URL del repositorio remoto.

### 5. Conectar el remoto

```bash
git remote add origin https://gitlab.com/USUARIO/REPOSITORIO.git
```

### 6. Subir los cambios

```bash
git branch -M main
git push -u origin main
```

### Si todavía no tienes acceso al GitLab del curso

Si al intentar entrar o subir el proyecto aparece un error de permisos, como `422` o un rechazo de cambio, significa que todavía no tienes autorización en ese grupo o repositorio. Cuando el profesor o el administrador te den acceso:

1. inicia sesión con tu cuenta de GitLab
2. abre el proyecto o grupo del curso
3. confirma que puedes ver el repositorio
4. vuelve a abrir la carpeta del proyecto en tu equipo
5. verifica el remoto con:

```bash
git remote -v
```

6. si hace falta, ajusta el remoto del proyecto al repositorio del curso:

```bash
git remote set-url origin https://git.isw.utm.ac.cr/isw-524/2026/ii-2026/g3-k/grupo-40.git
```

7. luego sube los cambios:

```bash
git add .
git commit -m "Update project before delivery"
git push -u origin main
```

Si GitLab pide contraseña, pega el token de acceso personal en ese momento, no lo guardes dentro del proyecto.

## Recomendaciones

- No subir carpetas generadas como `bin`, `obj` o `.vs`.
- Mantener commits pequeños y frecuentes.
- Si cambian la cadena de conexión, revisar el archivo de utilidades antes de entregar.

## Estado actual

El proyecto ya cuenta con:

- base de arquitectura por capas
- formularios iniciales
- documentación técnica
- script SQL inicial
- conexión preparada para SQL Server
