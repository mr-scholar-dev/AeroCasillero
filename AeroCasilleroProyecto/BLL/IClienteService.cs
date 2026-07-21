using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.BLL;

public interface IClienteService
{
    IEnumerable<ClienteDto> GetAll();
    ClienteDto? GetById(int id);
    ClienteDto? GetByDocumento(string cedulaPasaporte);
    int Create(ClienteDto cliente);
    bool Update(ClienteDto cliente);
    bool Delete(int id);
}
