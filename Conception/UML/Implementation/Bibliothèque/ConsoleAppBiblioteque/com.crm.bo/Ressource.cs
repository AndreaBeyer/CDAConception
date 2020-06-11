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
            this.emplacement = emplacement;
            this.exemplaires = exemplaires;
        }

        public Ressource(string titre, int caution, Emplacement emplacement)
        {
            this.titre = titre;
            this.caution = caution;
            this.emplacement = emplacement;
            this.exemplaires = new List<Exemplaire>();
        }

        public Ressource()
        {
            this.titre = null;
            this.caution = 0;
            this.emplacement = null;
            this.exemplaires = null;
        }

        public void AddExemplaire(Exemplaire exemplaire)
        {
            exemplaires.Add(exemplaire);
        }

        public string Titre { get => titre; set => titre = value; }
        public int Caution { get => caution; set => caution = value; }
        public Emplacement Emplacement { get => emplacement; set => emplacement = value; }
    }
}
