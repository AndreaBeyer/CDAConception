using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySingleton
{
    public class Singleton
    {
        private readonly static Singleton instance  = new Singleton();

        private int compteur;

        private Singleton()
        {
            Console.WriteLine("Instanciation d'un singleton");
        }

        public static Singleton GetInstance()
        {
            return instance;
        }

        public void Operation(string _name)
        {
            Console.WriteLine($"lancement de l'opération : {_name}");

            for (int i = 0; i < 5; i++)
            {
                compteur++;
            }

            Console.WriteLine($"Fin de l'opération. Le compteur est à {compteur}");
        }
    }
}
