using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBiblioteque
{
    class Program
    {
        static void Main(string[] args)
        {
            Livre ressource = new Livre("plo", 10, 10, "11", new Emplacement(1,1,1));

            Console.WriteLine(ressource.Titre);
        }
    }
}
