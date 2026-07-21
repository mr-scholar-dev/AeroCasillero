namespace AeroCasilleroProyecto.Entities;

public class Pago
{
    public int PagoId { get; set; }
    public DateTime FechaPago { get; set; }
    public decimal Monto { get; set; }
    public string Metodo { get; set; } = string.Empty;
    public string Referencia { get; set; } = string.Empty;

    public int FacturaId { get; set; }
    public Factura? Factura { get; set; }
}
