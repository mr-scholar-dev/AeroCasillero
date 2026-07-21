namespace AeroCasilleroProyecto.Entities;

public class Tarifa
{
    public int TarifaId { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public decimal MontoPorKg { get; set; }
    public decimal CobroMinimo { get; set; }
    public bool Activa { get; set; }
}
