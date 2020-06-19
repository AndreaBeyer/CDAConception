using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitor
{
    public class Dessin
    {
        private Carre carre;
        private Triangle triangle;

        public Dessin(Carre carre, Triangle triangle)
        {
            this.carre = carre;
            this.triangle = triangle;
        }

        public Carre Carre { get => carre; set => carre = value; }
        public Triangle Triangle { get => triangle; set => triangle = value; }
    }
}
