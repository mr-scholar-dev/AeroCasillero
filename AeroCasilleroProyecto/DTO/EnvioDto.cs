namespace AeroCasilleroProyecto.DTO;

public class EnvioDto
{
    public int EnvioId { get; set; }
    public string CodigoEnvio { get; set; } = string.Empty;
    public DateTime FechaCreacion { get; set; }
    public string Estado { get; set; } = string.Empty;
    public string TipoEntrega { get; set; } = string.Empty;
    public int ClienteId { get; set; }
    public string? ClienteNombre { get; set; }
}
