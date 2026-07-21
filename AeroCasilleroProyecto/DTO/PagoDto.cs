namespace AeroCasilleroProyecto.DTO;

public class PagoDto
{
    public int PagoId { get; set; }
    public DateTime FechaPago { get; set; }
    public decimal Monto { get; set; }
    public string Metodo { get; set; } = string.Empty;
    public string Referencia { get; set; } = string.Empty;
    public int FacturaId { get; set; }
    public string? NumeroFactura { get; set; }
}
