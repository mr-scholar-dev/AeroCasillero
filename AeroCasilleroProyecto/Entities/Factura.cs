namespace AeroCasilleroProyecto.Entities;

public class Factura
{
    public int FacturaId { get; set; }
    public string NumeroFactura { get; set; } = string.Empty;
    public DateTime FechaEmision { get; set; }
    public decimal Total { get; set; }

    public int EnvioId { get; set; }
    public Envio? Envio { get; set; }
}
