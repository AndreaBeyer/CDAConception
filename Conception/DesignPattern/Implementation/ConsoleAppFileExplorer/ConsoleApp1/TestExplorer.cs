using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExplorer
{
    class TestExplorer
    {
        static void Main(string[] args)
        {
            Dossier dossier = new Dossier("test");
            if (dossier.Repertorie())
            {
                Console.WriteLine(dossier.Formate());
            }

            Console.ReadKey();

        }
    }
}
