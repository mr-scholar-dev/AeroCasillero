using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Interfaces;
using AeroCasilleroProyecto.Util;
using Microsoft.Data.SqlClient;

namespace AeroCasilleroProyecto.DAL;

public class SqlClienteRepository : IClienteRepository
{
    public IEnumerable<ClienteDto> GetAll()
    {
        var result = new List<ClienteDto>();
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           SELECT c.ClienteId, c.Nombres, c.Apellidos, c.CedulaPasaporte, c.Correo, c.Telefono,
                                  c.CasilleroId, ca.NumeroCasillero
                           FROM Clientes c
                           INNER JOIN Casilleros ca ON ca.CasilleroId = c.CasilleroId
                           ORDER BY c.ClienteId DESC;
                           """;

        using var command = new SqlCommand(sql, connection);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            result.Add(Map(reader));
        }

        return result;
    }

    public ClienteDto? GetById(int id)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           SELECT c.ClienteId, c.Nombres, c.Apellidos, c.CedulaPasaporte, c.Correo, c.Telefono,
                                  c.CasilleroId, ca.NumeroCasillero
                           FROM Clientes c
                           INNER JOIN Casilleros ca ON ca.CasilleroId = c.CasilleroId
                           WHERE c.ClienteId = @Id;
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", id);
        using var reader = command.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public ClienteDto? GetByDocumento(string cedulaPasaporte)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           SELECT c.ClienteId, c.Nombres, c.Apellidos, c.CedulaPasaporte, c.Correo, c.Telefono,
                                  c.CasilleroId, ca.NumeroCasillero
                           FROM Clientes c
                           INNER JOIN Casilleros ca ON ca.CasilleroId = c.CasilleroId
                           WHERE c.CedulaPasaporte = @Documento;
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Documento", cedulaPasaporte);
        using var reader = command.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public int Add(ClienteDto entity)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           INSERT INTO Clientes (Nombres, Apellidos, CedulaPasaporte, Correo, Telefono, CasilleroId)
                           OUTPUT INSERTED.ClienteId
                           VALUES (@Nombres, @Apellidos, @Documento, @Correo, @Telefono, @CasilleroId);
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Nombres", entity.Nombres);
        command.Parameters.AddWithValue("@Apellidos", entity.Apellidos);
        command.Parameters.AddWithValue("@Documento", entity.CedulaPasaporte);
        command.Parameters.AddWithValue("@Correo", entity.Correo);
        command.Parameters.AddWithValue("@Telefono", entity.Telefono);
        command.Parameters.AddWithValue("@CasilleroId", entity.CasilleroId);
        return (int)command.ExecuteScalar()!;
    }

    public bool Update(ClienteDto entity)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           UPDATE Clientes
                           SET Nombres = @Nombres,
                               Apellidos = @Apellidos,
                               CedulaPasaporte = @Documento,
                               Correo = @Correo,
                               Telefono = @Telefono,
                               CasilleroId = @CasilleroId
                           WHERE ClienteId = @Id;
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", entity.ClienteId);
        command.Parameters.AddWithValue("@Nombres", entity.Nombres);
        command.Parameters.AddWithValue("@Apellidos", entity.Apellidos);
        command.Parameters.AddWithValue("@Documento", entity.CedulaPasaporte);
        command.Parameters.AddWithValue("@Correo", entity.Correo);
        command.Parameters.AddWithValue("@Telefono", entity.Telefono);
        command.Parameters.AddWithValue("@CasilleroId", entity.CasilleroId);
        return command.ExecuteNonQuery() > 0;
    }

    public bool Delete(int id)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        using var command = new SqlCommand("DELETE FROM Clientes WHERE ClienteId = @Id;", connection);
        command.Parameters.AddWithValue("@Id", id);
        return command.ExecuteNonQuery() > 0;
    }

    private static ClienteDto Map(SqlDataReader reader) => new()
    {
        ClienteId = reader.GetInt32(0),
        Nombres = reader.GetString(1),
        Apellidos = reader.GetString(2),
        CedulaPasaporte = reader.GetString(3),
        Correo = reader.GetString(4),
        Telefono = reader.GetString(5),
        CasilleroId = reader.GetInt32(6),
        NumeroCasillero = reader.GetString(7)
    };
}
