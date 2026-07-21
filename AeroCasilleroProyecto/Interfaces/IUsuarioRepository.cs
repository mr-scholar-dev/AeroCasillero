using AeroCasilleroProyecto.DTO;

namespace AeroCasilleroProyecto.Interfaces;

public interface IUsuarioRepository : IRepository<UsuarioDto>
{
    UsuarioDto? GetByNombreUsuario(string nombreUsuario);
    UsuarioDto? GetByCorreo(string correo);
}
