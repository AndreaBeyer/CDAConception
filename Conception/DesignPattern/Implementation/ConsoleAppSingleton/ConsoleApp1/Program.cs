using ClassLibrarySingleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Singleton singleton = Singleton.GetInstance();
                singleton.Operation($"Opération {i}");
            }
        }
    }
}
