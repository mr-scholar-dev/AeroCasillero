namespace AeroCasilleroProyecto.Entities;

public class Paquete
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
    public EstadoPaquete Estado { get; set; }

    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }

    public int? EnvioId { get; set; }
    public Envio? Envio { get; set; }
}
