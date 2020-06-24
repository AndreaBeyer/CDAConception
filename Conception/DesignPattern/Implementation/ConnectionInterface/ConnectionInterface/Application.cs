using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface
{
    public class Application
    {
        private IConnectionFactory connectionFactory;

        public Application(IConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public void Start()
        {
            IConnection connection = connectionFactory.GetConnection();
            connection.Connect();
        }
    }
}
