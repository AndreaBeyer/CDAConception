using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionInterface
{
    public class MySQLConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to MySQL...");
        }
    }
}
