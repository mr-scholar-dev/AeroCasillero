namespace AeroCasilleroProyecto.Entities;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string NombreUsuario { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public bool Activo { get; set; } = true;

    public int RolId { get; set; }
    public Rol? Rol { get; set; }
}
