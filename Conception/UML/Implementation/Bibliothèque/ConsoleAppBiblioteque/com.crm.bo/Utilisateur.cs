using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBibliothequeNameSpace
{
    public class Utilisateur
    {
        private string nom;
        private int caution;
        private List<Exemplaire> exemplaires;

        public Utilisateur(string nom, int caution, List<Exemplaire> exemplaires)
        {
            this.nom = nom;
            this.caution = caution;
            this.exemplaires = exemplaires;
        }

        public Utilisateur()
        {
            this.nom = null;
            this.caution = 0;
            this.exemplaires = null;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Caution { get => caution; set => caution = value; }
        public List<Exemplaire> Exemplaires { get => exemplaires; set => exemplaires = value; }
    }
}
