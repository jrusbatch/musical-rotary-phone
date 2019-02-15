using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace ClassLibrary1
{
    public class Database
    {
        private readonly SqlConnection _connection;

        public Database(string str)
        {
            _connection = new SqlConnection(str);
        }

        public IEnumerable<object> Query(string query)
        {
            return _connection.Query<object>(query);
        }
    }
}
