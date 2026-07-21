namespace AeroCasilleroProyecto.Entities;

public class Impuesto
{
    public int ImpuestoId { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public decimal Porcentaje { get; set; }
    public bool Activo { get; set; }
}
