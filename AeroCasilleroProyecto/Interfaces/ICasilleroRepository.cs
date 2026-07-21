using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.Interfaces;

public interface ICasilleroRepository : IRepository<CasilleroDto>
{
    CasilleroDto? GetByNumero(string numeroCasillero);
}
