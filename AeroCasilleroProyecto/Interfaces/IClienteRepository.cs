using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.Interfaces;

public interface IClienteRepository : IRepository<ClienteDto>
{
    ClienteDto? GetByDocumento(string cedulaPasaporte);
}
