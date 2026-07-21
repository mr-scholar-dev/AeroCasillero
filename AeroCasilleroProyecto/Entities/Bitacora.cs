namespace AeroCasilleroProyecto.Entities;

public class Bitacora
{
    public int BitacoraId { get; set; }
    public DateTime FechaHora { get; set; }
    public string Accion { get; set; } = string.Empty;
    public string Detalle { get; set; } = string.Empty;
    public string? Usuario { get; set; }
}
