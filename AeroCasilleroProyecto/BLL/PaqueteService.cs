using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Interfaces;

namespace AeroCasilleroProyecto.BLL;

public class PaqueteService : IPaqueteService
{
    private readonly IPaqueteRepository _repository;

    public PaqueteService(IPaqueteRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<PaqueteDto> GetAll() => _repository.GetAll();

    public PaqueteDto? GetById(int id) => _repository.GetById(id);

    public PaqueteDto? GetByTracking(string tracking)
    {
        if (string.IsNullOrWhiteSpace(tracking))
        {
            return null;
        }

        return _repository.GetByTracking(tracking.Trim());
    }

    public int Create(PaqueteDto paquete)
    {
        Validar(paquete);
        return _repository.Add(paquete);
    }

    public bool Update(PaqueteDto paquete)
    {
        Validar(paquete);
        return _repository.Update(paquete);
    }

    public bool Delete(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("El identificador del paquete no es válido.", nameof(id));
        }

        return _repository.Delete(id);
    }

    private static void Validar(PaqueteDto paquete)
    {
        ArgumentNullException.ThrowIfNull(paquete);

        if (string.IsNullOrWhiteSpace(paquete.Tracking))
        {
            throw new ArgumentException("El tracking es obligatorio.");
        }

        if (paquete.Peso <= 0)
        {
            throw new ArgumentException("El peso debe ser mayor que cero.");
        }

        if (paquete.Alto <= 0 || paquete.Ancho <= 0 || paquete.Largo <= 0)
        {
            throw new ArgumentException("Las dimensiones deben ser mayores que cero.");
        }

        if (string.IsNullOrWhiteSpace(paquete.Transportista))
        {
            throw new ArgumentException("El transportista es obligatorio.");
        }
    }
}
