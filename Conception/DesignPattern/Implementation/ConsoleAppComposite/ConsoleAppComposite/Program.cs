using ClassLibraryComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite c1 = new Composite("c1");
            Composite c2 = new Composite("c2");
            c1.AddComponent(c2);
            c1.AddComponent(new Leaf("l11"));
            c1.AddComponent(new Leaf("l12"));
            c2.AddComponent(new Leaf("l21"));

            c1.Operation();
        }
    }
}
