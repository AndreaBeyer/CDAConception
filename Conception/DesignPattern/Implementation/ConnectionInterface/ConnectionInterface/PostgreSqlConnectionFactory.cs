using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface
{
    public class PostgreSqlConnectionFactory : IConnectionFactory
    {
        public IConnection GetConnection()
        {
            return new PostgreSqlConnection();
        }
    }
}
