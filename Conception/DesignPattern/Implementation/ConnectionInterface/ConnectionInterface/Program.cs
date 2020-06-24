using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseType databaseType = DatabaseType.MYSQL;

            IConnectionFactory connectionFactory = GetConnectionFactory(databaseType);

            Application application = new Application(connectionFactory);

            application.Start();

        }

        private static IConnectionFactory GetConnectionFactory(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case DatabaseType.MYSQL:
                    return new MySqlConnectionFactory();
                case DatabaseType.POSTGRE:
                    return new PostgreSqlConnectionFactory();
                default:
                    return null;
            }
        }

        private enum DatabaseType
        {
            MYSQL, POSTGRE
        }
    }
}
