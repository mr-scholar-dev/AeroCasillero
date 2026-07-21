namespace AeroCasilleroProyecto.Entities;

public class Casillero
{
    public int CasilleroId { get; set; }
    public string NumeroCasillero { get; set; } = string.Empty;
    public string Ubicacion { get; set; } = string.Empty;
    public string Tamano { get; set; } = string.Empty;
    public EstadoCasillero Estado { get; set; }

    public Cliente? Cliente { get; set; }
}
