using AeroCasilleroProyecto.DTO;
using AeroCasilleroProyecto.Interfaces;
using AeroCasilleroProyecto.Util;
using Microsoft.Data.SqlClient;

namespace AeroCasilleroProyecto.DAL;

public class SqlCasilleroRepository : ICasilleroRepository
{
    public IEnumerable<CasilleroDto> GetAll()
    {
        var result = new List<CasilleroDto>();
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           SELECT CasilleroId, NumeroCasillero, Ubicacion, Tamano, Estado
                           FROM Casilleros
                           ORDER BY CasilleroId DESC;
                           """;

        using var command = new SqlCommand(sql, connection);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            result.Add(Map(reader));
        }

        return result;
    }

    public CasilleroDto? GetById(int id)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           SELECT CasilleroId, NumeroCasillero, Ubicacion, Tamano, Estado
                           FROM Casilleros
                           WHERE CasilleroId = @Id;
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", id);
        using var reader = command.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public CasilleroDto? GetByNumero(string numeroCasillero)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           SELECT CasilleroId, NumeroCasillero, Ubicacion, Tamano, Estado
                           FROM Casilleros
                           WHERE NumeroCasillero = @Numero;
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Numero", numeroCasillero);
        using var reader = command.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public int Add(CasilleroDto entity)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           INSERT INTO Casilleros (NumeroCasillero, Ubicacion, Tamano, Estado)
                           OUTPUT INSERTED.CasilleroId
                           VALUES (@Numero, @Ubicacion, @Tamano, @Estado);
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Numero", entity.NumeroCasillero);
        command.Parameters.AddWithValue("@Ubicacion", entity.Ubicacion);
        command.Parameters.AddWithValue("@Tamano", entity.Tamano);
        command.Parameters.AddWithValue("@Estado", entity.Estado);
        return (int)command.ExecuteScalar()!;
    }

    public bool Update(CasilleroDto entity)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        const string sql = """
                           UPDATE Casilleros
                           SET NumeroCasillero = @Numero,
                               Ubicacion = @Ubicacion,
                               Tamano = @Tamano,
                               Estado = @Estado
                           WHERE CasilleroId = @Id;
                           """;

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", entity.CasilleroId);
        command.Parameters.AddWithValue("@Numero", entity.NumeroCasillero);
        command.Parameters.AddWithValue("@Ubicacion", entity.Ubicacion);
        command.Parameters.AddWithValue("@Tamano", entity.Tamano);
        command.Parameters.AddWithValue("@Estado", entity.Estado);
        return command.ExecuteNonQuery() > 0;
    }

    public bool Delete(int id)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();

        using var command = new SqlCommand("DELETE FROM Casilleros WHERE CasilleroId = @Id;", connection);
        command.Parameters.AddWithValue("@Id", id);
        return command.ExecuteNonQuery() > 0;
    }

    private static CasilleroDto Map(SqlDataReader reader) => new()
    {
        CasilleroId = reader.GetInt32(0),
        NumeroCasillero = reader.GetString(1),
        Ubicacion = reader.GetString(2),
        Tamano = reader.GetString(3),
        Estado = reader.GetString(4)
    };
}
