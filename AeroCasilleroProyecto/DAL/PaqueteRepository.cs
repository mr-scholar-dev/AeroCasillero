using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Interfaces;

namespace AeroCasilleroProyecto.DAL;

public class PaqueteRepository : InMemoryRepository<PaqueteDto>, IPaqueteRepository
{
    private int _nextId = 1;

    public override PaqueteDto? GetById(int id) => Items.FirstOrDefault(x => x.PaqueteId == id);

    public PaqueteDto? GetByTracking(string tracking) =>
        Items.FirstOrDefault(x => string.Equals(x.Tracking, tracking, StringComparison.OrdinalIgnoreCase));

    public override int Add(PaqueteDto entity)
    {
        entity.PaqueteId = _nextId++;
        Items.Add(entity);
        return entity.PaqueteId;
    }

    public override bool Update(PaqueteDto entity)
    {
        var index = Items.FindIndex(x => x.PaqueteId == entity.PaqueteId);
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
