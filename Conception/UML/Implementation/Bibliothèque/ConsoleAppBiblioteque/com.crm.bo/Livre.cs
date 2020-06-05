using ConsoleAppBiblioteque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBibliothequeNameSpace
{
    public class Livre : Ressource
    {
        private int isbn;
        private string auteur;
        private Emplacement monEmplacement;

        public Livre(string titre, int caution, int isbn, string auteur, Emplacement emplacement) : base(titre, caution, emplacement)
        {
            this.Isbn = isbn;
            this.Auteur = auteur;
        }

        public Livre() : base()
        {
            this.Isbn = 0;
            this.Auteur = null;
        }

        public int Isbn { get => isbn; set => isbn = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public Emplacement MonEmplacement { get => monEmplacement; set => monEmplacement = value; }
    }
}
