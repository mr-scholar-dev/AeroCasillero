namespace AeroCasilleroProyecto.DTO;

public class UsuarioDto
{
    public int UsuarioId { get; set; }
    public string NombreUsuario { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public bool Activo { get; set; }
    public int RolId { get; set; }
    public string? RolNombre { get; set; }
}
