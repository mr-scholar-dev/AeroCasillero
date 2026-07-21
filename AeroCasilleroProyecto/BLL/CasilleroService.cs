using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Interfaces;

namespace AeroCasilleroProyecto.BLL;

public class CasilleroService : ICasilleroService
{
    private readonly ICasilleroRepository _repository;

    public CasilleroService(ICasilleroRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<CasilleroDto> GetAll() => _repository.GetAll();

    public CasilleroDto? GetById(int id) => _repository.GetById(id);

    public CasilleroDto? GetByNumero(string numeroCasillero)
    {
        if (string.IsNullOrWhiteSpace(numeroCasillero))
        {
            return null;
        }

        return _repository.GetByNumero(numeroCasillero.Trim());
    }

    public int Create(CasilleroDto casillero)
    {
        Validar(casillero);
        return _repository.Add(casillero);
    }

    public bool Update(CasilleroDto casillero)
    {
        Validar(casillero);
        return _repository.Update(casillero);
    }

    public bool Delete(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("El identificador del casillero no es válido.", nameof(id));
        }

        return _repository.Delete(id);
    }

    private static void Validar(CasilleroDto casillero)
    {
        ArgumentNullException.ThrowIfNull(casillero);

        if (string.IsNullOrWhiteSpace(casillero.NumeroCasillero))
        {
            throw new ArgumentException("El número de casillero es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(casillero.Ubicacion))
        {
            throw new ArgumentException("La ubicación es obligatoria.");
        }

        if (string.IsNullOrWhiteSpace(casillero.Tamano))
        {
            throw new ArgumentException("El tamaño es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(casillero.Estado))
        {
            throw new ArgumentException("El estado es obligatorio.");
        }
    }
}
