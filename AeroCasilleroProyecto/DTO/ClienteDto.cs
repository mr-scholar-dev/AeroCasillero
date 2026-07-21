namespace AeroCasilleroProyecto.DTO;

public class ClienteDto
{
    public int ClienteId { get; set; }
    public string Nombres { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public string CedulaPasaporte { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public int CasilleroId { get; set; }
    public string? NumeroCasillero { get; set; }
}
