using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Entities;

namespace AeroCasilleroProyecto.Util;

public static class DtoMapper
{
    public static ClienteDto ToDto(this Cliente entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        return new ClienteDto
        {
            ClienteId = entity.ClienteId,
            Nombres = entity.Nombres,
            Apellidos = entity.Apellidos,
            CedulaPasaporte = entity.CedulaPasaporte,
            Correo = entity.Correo,
            Telefono = entity.Telefono,
            CasilleroId = entity.CasilleroId,
            NumeroCasillero = entity.Casillero?.NumeroCasillero
        };
    }

    public static Cliente ToEntity(this ClienteDto dto)
    {
        ArgumentNullException.ThrowIfNull(dto);

        return new Cliente
        {
            ClienteId = dto.ClienteId,
            Nombres = dto.Nombres,
            Apellidos = dto.Apellidos,
            CedulaPasaporte = dto.CedulaPasaporte,
            Correo = dto.Correo,
            Telefono = dto.Telefono,
            CasilleroId = dto.CasilleroId
        };
    }

    public static CasilleroDto ToDto(this Casillero entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        return new CasilleroDto
        {
            CasilleroId = entity.CasilleroId,
            NumeroCasillero = entity.NumeroCasillero,
            Ubicacion = entity.Ubicacion,
            Tamano = entity.Tamano,
            Estado = entity.Estado.ToString()
        };
    }

    public static Casillero ToEntity(this CasilleroDto dto)
    {
        ArgumentNullException.ThrowIfNull(dto);

        return new Casillero
        {
            CasilleroId = dto.CasilleroId,
            NumeroCasillero = dto.NumeroCasillero,
            Ubicacion = dto.Ubicacion,
            Tamano = dto.Tamano,
            Estado = Enum.TryParse<EstadoCasillero>(dto.Estado, true, out var estado)
                ? estado
                : EstadoCasillero.Disponible
        };
    }

    public static PaqueteDto ToDto(this Paquete entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        return new PaqueteDto
        {
            PaqueteId = entity.PaqueteId,
            Tracking = entity.Tracking,
            Peso = entity.Peso,
            Alto = entity.Alto,
            Ancho = entity.Ancho,
            Largo = entity.Largo,
            Transportista = entity.Transportista,
            FechaRecepcion = entity.FechaRecepcion,
            Observaciones = entity.Observaciones,
            Estado = entity.Estado.ToString(),
            ClienteId = entity.ClienteId,
            ClienteNombre = entity.Cliente is null ? null : $"{entity.Cliente.Nombres} {entity.Cliente.Apellidos}",
            EnvioId = entity.EnvioId,
            CodigoEnvio = entity.Envio?.CodigoEnvio
        };
    }

    public static Paquete ToEntity(this PaqueteDto dto)
    {
        ArgumentNullException.ThrowIfNull(dto);

        return new Paquete
        {
            PaqueteId = dto.PaqueteId,
            Tracking = dto.Tracking,
            Peso = dto.Peso,
            Alto = dto.Alto,
            Ancho = dto.Ancho,
            Largo = dto.Largo,
            Transportista = dto.Transportista,
            FechaRecepcion = dto.FechaRecepcion,
            Observaciones = dto.Observaciones,
            Estado = Enum.TryParse<EstadoPaquete>(dto.Estado, true, out var estado)
                ? estado
                : EstadoPaquete.RecibidoEnBodega,
            ClienteId = dto.ClienteId,
            EnvioId = dto.EnvioId
        };
    }
}
