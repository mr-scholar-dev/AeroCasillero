using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Interfaces;

namespace AeroCasilleroProyecto.DAL;

public class ClienteRepository : InMemoryRepository<ClienteDto>, IClienteRepository
{
    private int _nextId = 1;

    public override ClienteDto? GetById(int id) => Items.FirstOrDefault(x => x.ClienteId == id);

    public ClienteDto? GetByDocumento(string cedulaPasaporte) =>
        Items.FirstOrDefault(x => string.Equals(x.CedulaPasaporte, cedulaPasaporte, StringComparison.OrdinalIgnoreCase));

    public override int Add(ClienteDto entity)
    {
        entity.ClienteId = _nextId++;
        Items.Add(entity);
        return entity.ClienteId;
    }

    public override bool Update(ClienteDto entity)
    {
        var index = Items.FindIndex(x => x.ClienteId == entity.ClienteId);
        if (index < 0)
        {
            return false;
        }

        Items[index] = entity;
        return true;
    }

    public override bool Delete(int id)
    {
        var item = GetById(id);
        if (item is null)
        {
            return false;
        }

        Items.Remove(item);
        return true;
    }
}
