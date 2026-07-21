namespace AeroCasilleroProyecto.Entities;

public class Envio
{
    public int EnvioId { get; set; }
    public string CodigoEnvio { get; set; } = string.Empty;
    public DateTime FechaCreacion { get; set; }
    public EstadoPaquete Estado { get; set; }
    public TipoEntrega TipoEntrega { get; set; }

    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }
    public List<Paquete> Paquetes { get; set; } = new();
}
