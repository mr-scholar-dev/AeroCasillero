using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.Interfaces;

public interface IPaqueteRepository : IRepository<PaqueteDto>
{
    PaqueteDto? GetByTracking(string tracking);
}
