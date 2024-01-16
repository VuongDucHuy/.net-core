using System.Data;
using System.Data.SqlClient;
using TRANNING.IServices;

namespace TRANNING.Repository
{
    public class SQLServerConnection : ISQLServerConnection
    {
        private string _connectionString;
        public SQLServerConnection(string connectionString)
        {
            _connectionString = connectionString;
        }


        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public SqlConnection CreateConnectionWithStats()
        {
            var sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.StatisticsEnabled = true;
            sqlConnection.ResetStatistics();
            return sqlConnection;
        }
    }
}
