namespace AeroCasilleroProyecto.DTO;

public class FacturaDto
{
    public int FacturaId { get; set; }
    public string NumeroFactura { get; set; } = string.Empty;
    public DateTime FechaEmision { get; set; }
    public decimal Total { get; set; }
    public int EnvioId { get; set; }
    public string? CodigoEnvio { get; set; }
}
