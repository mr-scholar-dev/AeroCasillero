using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.Interfaces;

public interface IRolRepository : IRepository<RolDto>
{
    RolDto? GetByNombre(string nombre);
}
