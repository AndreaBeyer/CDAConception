using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface
{
    public class MySqlConnectionFactory : IConnectionFactory
    {
        public IConnection GetConnection()
        {
            return new MySQLConnection();
        }
    }
}
