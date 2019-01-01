using MySql.Data.MySqlClient;
using Dapper;
using System.Collections.Generic;
using Whisp.Application.Interfaces;

namespace Whisp.Persistence
{
    public class MySqlDatabase : IDatabase
    {
        private readonly IConfig _config = null;

        public MySqlDatabase(IConfig config)
        {
            _config = config;
        }

        public void Execute(string sql)
        {
            using (var connection = new MySqlConnection(_config.ConnectionString))
            {
                connection.Execute(sql);
            }
        }

        public void Execute(string sql, object param)
        {
            using (var connection = new MySqlConnection(_config.ConnectionString))
            {
                connection.Execute(sql, param);
            }
        }

        public IEnumerable<T> Query<T>(string sql)
        {
            return Query<T>(sql, null);
        }

        public IEnumerable<T> Query<T>(string sql, object param)
        {
            using (var connection = new MySqlConnection(_config.ConnectionString))
            {
                return connection.Query<T>(sql, param);
            }
        }
    }
}
