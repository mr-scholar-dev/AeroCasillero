namespace AeroCasilleroProyecto.Entities;

public enum EstadoCasillero
{
    Disponible = 1,
    FueraDeServicio = 2
}

public enum EstadoPaquete
{
    RecibidoEnBodega = 1,
    EnConsolidacion = 2,
    EnVuelo = 3,
    EnAduana = 4,
    Entregado = 5
}

public enum TipoEntrega
{
    RetiroEnOficina = 1,
    EntregaADomicilio = 2
}
