using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.BLL;

public interface IPaqueteService
{
    IEnumerable<PaqueteDto> GetAll();
    PaqueteDto? GetById(int id);
    PaqueteDto? GetByTracking(string tracking);
    int Create(PaqueteDto paquete);
    bool Update(PaqueteDto paquete);
    bool Delete(int id);
}
