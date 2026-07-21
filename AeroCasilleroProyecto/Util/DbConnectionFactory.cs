using Microsoft.Data.SqlClient;

namespace AeroCasilleroProyecto.Util;

public static class DbConnectionFactory
{
    public static SqlConnection CreateConnection()
    {
        return new SqlConnection(AppConstants.ConnectionString);
    }
}
