using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExplorer
{
    public abstract class Composant
    {
        public string path;
        public int indetentation;
        public string nom;


        public Composant()
        {
        }

        public Composant(string _nom, int indetentation)
        {
            this.nom = Path.GetFileName(_nom);
            
            this.indetentation = indetentation;
            path = _nom;

        }

        public Composant(string nom)
        {
            this.nom = nom;
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + nom;
            indetentation = 1;
        }

        public abstract string Formate();

        public abstract bool Repertorie();

    }
}
