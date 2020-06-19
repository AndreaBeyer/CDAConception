using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExplorer
{
    public abstract class Composite : Composant
    {

        public List<Composant> composants;

        public Composite(string nom) : base(nom)
        {
            composants = new List<Composant>();
        }

        public Composite(string path, int indetentation) : base(path, indetentation)
        {
            composants = new List<Composant>();
        }

        

        public override bool Repertorie()
        {
            int i = this.indetentation;

            foreach (string str in Directory.GetFileSystemEntries(path))
            {

                if (File.GetAttributes(str).HasFlag(FileAttributes.Directory))
                {
                    composants.Add(new Dossier(str, i+1));
                }
                else
                {
                    Fichier comp = new Fichier(str, i);
                    composants.Add(comp);
                }

            }
            return true;
        }
    }
}
