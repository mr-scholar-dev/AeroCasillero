using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.Interfaces;

public interface IVueloRepository : IRepository<VueloDto>
{
    VueloDto? GetByNumero(string numeroVuelo);
}
