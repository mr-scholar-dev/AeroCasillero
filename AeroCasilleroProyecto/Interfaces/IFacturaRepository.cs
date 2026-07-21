using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.Interfaces;

public interface IFacturaRepository : IRepository<FacturaDto>
{
    FacturaDto? GetByNumero(string numeroFactura);
}
