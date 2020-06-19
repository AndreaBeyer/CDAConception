using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExplorer
{
    public class Fichier : Composant
    {
        public Fichier(string nom, int indetentation) : base(nom, indetentation)
        {
        }

        public override string Formate()
        {
            string tempS = "";
            for (int i = 0; i < indetentation; i++)
            {
                tempS += "./";
            }
            tempS += this.nom;
            tempS += "\n";

            return tempS;
        }

        public override bool Repertorie()
        {
            return false;
        }
    }
}
