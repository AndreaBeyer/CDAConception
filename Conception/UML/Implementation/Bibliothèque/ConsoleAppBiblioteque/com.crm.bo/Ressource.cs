using ConsoleAppBiblioteque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBibliothequeNameSpace
{
    public abstract class Ressource
    {
        private string titre;
        private int caution;
        private Emplacement emplacement;
        private List<Exemplaire> exemplaires;

        public Ressource(string titre, int caution, Emplacement emplacement, List<Exemplaire> exemplaires)
        {
            this.titre = titre;
            this.caution = caution;
            this.Emplacement = emplacement;
            this.Exemplaires = exemplaires;
        }

        public Ressource(string titre, int caution, Emplacement emplacement)
        {
            this.titre = titre;
            this.caution = caution;
            this.Emplacement = emplacement;
            this.Exemplaires = new List<Exemplaire>();
        }

        public Ressource()
        {
            this.titre = null;
            this.caution = 0;
            this.Emplacement = null;
            this.Exemplaires = null;
        }

        public string Titre { get => titre; set => titre = value; }
        public int Caution { get => caution; set => caution = value; }
        public Emplacement Emplacement { get => emplacement; set => emplacement = value; }
        public List<Exemplaire> Exemplaires { get => exemplaires; set => exemplaires = value; }
    }
}
