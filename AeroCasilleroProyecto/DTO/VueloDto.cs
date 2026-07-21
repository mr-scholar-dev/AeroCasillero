namespace AeroCasilleroProyecto.DTO;

public class VueloDto
{
    public int VueloId { get; set; }
    public string NumeroVuelo { get; set; } = string.Empty;
    public string Aerolinea { get; set; } = string.Empty;
    public DateTime FechaSalida { get; set; }
    public DateTime FechaLlegadaEstimada { get; set; }
    public string Origen { get; set; } = string.Empty;
    public string Destino { get; set; } = string.Empty;
}
