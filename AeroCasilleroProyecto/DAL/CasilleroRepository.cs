using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Interfaces;

namespace AeroCasilleroProyecto.DAL;

public class CasilleroRepository : InMemoryRepository<CasilleroDto>, ICasilleroRepository
{
    private int _nextId = 1;

    public override CasilleroDto? GetById(int id) => Items.FirstOrDefault(x => x.CasilleroId == id);

    public CasilleroDto? GetByNumero(string numeroCasillero) =>
        Items.FirstOrDefault(x => string.Equals(x.NumeroCasillero, numeroCasillero, StringComparison.OrdinalIgnoreCase));

    public override int Add(CasilleroDto entity)
    {
        entity.CasilleroId = _nextId++;
        Items.Add(entity);
        return entity.CasilleroId;
    }

    public override bool Update(CasilleroDto entity)
    {
        var index = Items.FindIndex(x => x.CasilleroId == entity.CasilleroId);
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
