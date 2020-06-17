using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComposite
{
    public class Leaf : Component
    {
        public Leaf(string nom) : base(nom)
        {
        }

        public override void Operation()
        {
            string tempS = "";

            for (int i = 0; i < niveau; i++)
            {
                tempS += "--";
            }

            Console.WriteLine($"{tempS} Element unique : {nom}");
        }
    }
}
