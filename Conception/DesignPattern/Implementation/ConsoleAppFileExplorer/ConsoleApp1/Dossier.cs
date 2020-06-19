using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExplorer
{
    public class Dossier : Composite
    {
        public Dossier(string nom) : base(nom)
        {
        }

        public Dossier(string nom, int indetentation) : base(nom, indetentation)
        {
        }

        public override string Formate()
        {
            string tempS = "";

            foreach(Composant comp in composants)
            {
                int j = indetentation;

                for (int i = 0; i < j; i++)
                {
                    tempS += "./";
                }
                
                tempS += comp.nom;
                tempS += "\n";

                if (File.GetAttributes(comp.path).HasFlag(FileAttributes.Directory))
                {
                    comp.Repertorie();
                    tempS += comp.Formate();
                }

            }

            return tempS;
        }
        
    }
}
