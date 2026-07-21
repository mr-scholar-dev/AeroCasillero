namespace AeroCasilleroProyecto.DTO;

public class PaqueteDto
{
    public int PaqueteId { get; set; }
    public string Tracking { get; set; } = string.Empty;
    public decimal Peso { get; set; }
    public decimal Alto { get; set; }
    public decimal Ancho { get; set; }
    public decimal Largo { get; set; }
    public string Transportista { get; set; } = string.Empty;
    public DateTime FechaRecepcion { get; set; }
    public string? Observaciones { get; set; }
    public string Estado { get; set; } = string.Empty;
    public int ClienteId { get; set; }
    public string? ClienteNombre { get; set; }
    public int? EnvioId { get; set; }
    public string? CodigoEnvio { get; set; }
}
