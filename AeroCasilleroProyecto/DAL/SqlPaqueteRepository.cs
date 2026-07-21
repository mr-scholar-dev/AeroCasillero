using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Interfaces;
using AeroCasilleroProyecto.Util;
using Microsoft.Data.SqlClient;

namespace AeroCasilleroProyecto.DAL;

public class SqlPaqueteRepository : IPaqueteRepository
{
    public IEnumerable<PaqueteDto> GetAll()
    {
        var result = new List<PaqueteDto>();
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           SELECT p.PaqueteId, p.Tracking, p.Peso, p.Alto, p.Ancho, p.Largo,
                                  p.Transportista, p.FechaRecepcion, p.Observaciones, p.Estado,
                                  p.ClienteId, CONCAT(c.Nombres, ' ', c.Apellidos) AS ClienteNombre,
                                  p.EnvioId, e.CodigoEnvio
                           FROM Paquetes p
                           INNER JOIN Clientes c ON c.ClienteId = p.ClienteId
                           LEFT JOIN Envios e ON e.EnvioId = p.EnvioId
                           ORDER BY p.PaqueteId DESC;
                           """;

        using var command = new SqlCommand(sql, connection);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            result.Add(Map(reader));
        }

        return result;
    }

    public PaqueteDto? GetById(int id)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           SELECT p.PaqueteId, p.Tracking, p.Peso, p.Alto, p.Ancho, p.Largo,
                                  p.Transportista, p.FechaRecepcion, p.Observaciones, p.Estado,
                                  p.ClienteId, CONCAT(c.Nombres, ' ', c.Apellidos) AS ClienteNombre,
                                  p.EnvioId, e.CodigoEnvio
                           FROM Paquetes p
                           INNER JOIN Clientes c ON c.ClienteId = p.ClienteId
                           LEFT JOIN Envios e ON e.EnvioId = p.EnvioId
                           WHERE p.PaqueteId = @Id;
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", id);
        using var reader = command.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public PaqueteDto? GetByTracking(string tracking)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           SELECT p.PaqueteId, p.Tracking, p.Peso, p.Alto, p.Ancho, p.Largo,
                                  p.Transportista, p.FechaRecepcion, p.Observaciones, p.Estado,
                                  p.ClienteId, CONCAT(c.Nombres, ' ', c.Apellidos) AS ClienteNombre,
                                  p.EnvioId, e.CodigoEnvio
                           FROM Paquetes p
                           INNER JOIN Clientes c ON c.ClienteId = p.ClienteId
                           LEFT JOIN Envios e ON e.EnvioId = p.EnvioId
                           WHERE p.Tracking = @Tracking;
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Tracking", tracking);
        using var reader = command.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public int Add(PaqueteDto entity)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           INSERT INTO Paquetes (Tracking, Peso, Alto, Ancho, Largo, Transportista, FechaRecepcion, Observaciones, Estado, ClienteId, EnvioId)
                           OUTPUT INSERTED.PaqueteId
                           VALUES (@Tracking, @Peso, @Alto, @Ancho, @Largo, @Transportista, @FechaRecepcion, @Observaciones, @Estado, @ClienteId, @EnvioId);
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Tracking", entity.Tracking);
        command.Parameters.AddWithValue("@Peso", entity.Peso);
        command.Parameters.AddWithValue("@Alto", entity.Alto);
        command.Parameters.AddWithValue("@Ancho", entity.Ancho);
        command.Parameters.AddWithValue("@Largo", entity.Largo);
        command.Parameters.AddWithValue("@Transportista", entity.Transportista);
        command.Parameters.AddWithValue("@FechaRecepcion", entity.FechaRecepcion);
        command.Parameters.AddWithValue("@Observaciones", (object?)entity.Observaciones ?? DBNull.Value);
        command.Parameters.AddWithValue("@Estado", entity.Estado);
        command.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
        command.Parameters.AddWithValue("@EnvioId", (object?)entity.EnvioId ?? DBNull.Value);
        return (int)command.ExecuteScalar()!;
    }

    public bool Update(PaqueteDto entity)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           UPDATE Paquetes
                           SET Tracking = @Tracking,
                               Peso = @Peso,
                               Alto = @Alto,
                               Ancho = @Ancho,
                               Largo = @Largo,
                               Transportista = @Transportista,
                               FechaRecepcion = @FechaRecepcion,
                               Observaciones = @Observaciones,
                               Estado = @Estado,
                               ClienteId = @ClienteId,
                               EnvioId = @EnvioId
                           WHERE PaqueteId = @Id;
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", entity.PaqueteId);
        command.Parameters.AddWithValue("@Tracking", entity.Tracking);
        command.Parameters.AddWithValue("@Peso", entity.Peso);
        command.Parameters.AddWithValue("@Alto", entity.Alto);
        command.Parameters.AddWithValue("@Ancho", entity.Ancho);
        command.Parameters.AddWithValue("@Largo", entity.Largo);
        command.Parameters.AddWithValue("@Transportista", entity.Transportista);
        command.Parameters.AddWithValue("@FechaRecepcion", entity.FechaRecepcion);
        command.Parameters.AddWithValue("@Observaciones", (object?)entity.Observaciones ?? DBNull.Value);
        command.Parameters.AddWithValue("@Estado", entity.Estado);
        command.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
        command.Parameters.AddWithValue("@EnvioId", (object?)entity.EnvioId ?? DBNull.Value);
        return command.ExecuteNonQuery() > 0;
    }

    public bool Delete(int id)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        using var command = new SqlCommand("DELETE FROM Paquetes WHERE PaqueteId = @Id;", connection);
        command.Parameters.AddWithValue("@Id", id);
        return command.ExecuteNonQuery() > 0;
    }

    private static PaqueteDto Map(SqlDataReader reader) => new()
    {
        PaqueteId = reader.GetInt32(0),
        Tracking = reader.GetString(1),
        Peso = reader.GetDecimal(2),
        Alto = reader.GetDecimal(3),
        Ancho = reader.GetDecimal(4),
        Largo = reader.GetDecimal(5),
        Transportista = reader.GetString(6),
        FechaRecepcion = reader.GetDateTime(7),
        Observaciones = reader.IsDBNull(8) ? null : reader.GetString(8),
        Estado = reader.GetString(9),
        ClienteId = reader.GetInt32(10),
        ClienteNombre = reader.GetString(11),
        EnvioId = reader.IsDBNull(12) ? null : reader.GetInt32(12),
        CodigoEnvio = reader.IsDBNull(13) ? null : reader.GetString(13)
    };
}
