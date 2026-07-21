using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.BLL;

public interface ICasilleroService
{
    IEnumerable<CasilleroDto> GetAll();
    CasilleroDto? GetById(int id);
    CasilleroDto? GetByNumero(string numeroCasillero);
    int Create(CasilleroDto casillero);
    bool Update(CasilleroDto casillero);
    bool Delete(int id);
}
