using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Interfaces;

namespace AeroCasilleroProyecto.BLL;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repository;

    public ClienteService(IClienteRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<ClienteDto> GetAll() => _repository.GetAll();

    public ClienteDto? GetById(int id) => _repository.GetById(id);

    public ClienteDto? GetByDocumento(string cedulaPasaporte)
    {
        if (string.IsNullOrWhiteSpace(cedulaPasaporte))
        {
            return null;
        }

        return _repository.GetByDocumento(cedulaPasaporte.Trim());
    }

    public int Create(ClienteDto cliente)
    {
        Validar(cliente);
        return _repository.Add(cliente);
    }

    public bool Update(ClienteDto cliente)
    {
        Validar(cliente);
        return _repository.Update(cliente);
    }

    public bool Delete(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("El identificador del cliente no es válido.", nameof(id));
        }

        return _repository.Delete(id);
    }

    private static void Validar(ClienteDto cliente)
    {
        ArgumentNullException.ThrowIfNull(cliente);

        if (string.IsNullOrWhiteSpace(cliente.Nombres))
        {
            throw new ArgumentException("El nombre del cliente es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(cliente.Apellidos))
        {
            throw new ArgumentException("Los apellidos del cliente son obligatorios.");
        }

        if (string.IsNullOrWhiteSpace(cliente.CedulaPasaporte))
        {
            throw new ArgumentException("La cédula o pasaporte es obligatoria.");
        }

        if (string.IsNullOrWhiteSpace(cliente.Correo))
        {
            throw new ArgumentException("El correo del cliente es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(cliente.Telefono))
        {
            throw new ArgumentException("El teléfono del cliente es obligatorio.");
        }
    }
}
