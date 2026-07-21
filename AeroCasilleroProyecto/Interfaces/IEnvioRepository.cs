using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.Interfaces;

public interface IEnvioRepository : IRepository<EnvioDto>
{
    EnvioDto? GetByCodigo(string codigoEnvio);
}
