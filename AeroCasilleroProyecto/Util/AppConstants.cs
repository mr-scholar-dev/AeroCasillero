namespace AeroCasilleroProyecto.Util;

public static class AppConstants
{
    public const string ConnectionString = "Server=localhost;Database=AeroCasilleroProyecto;Trusted_Connection=True;TrustServerCertificate=True;";

    public const string EstadoCasilleroDisponible = "Disponible";
    public const string EstadoCasilleroFueraDeServicio = "FueraDeServicio";
    public const string EstadoPaqueteRecibido = "RecibidoEnBodega";
    public const string TipoEntregaRetiroEnOficina = "RetiroEnOficina";
    public const string TipoEntregaDomicilio = "EntregaADomicilio";

    public const decimal CobroMinimoDefault = 0m;
    public const decimal PesoMinimoPaquete = 0.01m;
}
