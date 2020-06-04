using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBiblioteque
{
    public class Emplacement
    {
        private int travee;
        private int etagere;
        private int niveau;

        private List<Ressource> ressources;

        public Emplacement(int travee, int etagere, int niveau, List<Ressource> ressources)
        {
            this.Travee = travee;
            this.Etagere = etagere;
            this.Niveau = niveau;
            this.Ressources = ressources;
        }

        public Emplacement(int travee, int etagere, int niveau)
        {
            this.Travee = travee;
            this.Etagere = etagere;
            this.Niveau = niveau;
            this.Ressources = new List<Ressource>();
        }

        public Emplacement()
        {
            this.Travee = 0;
            this.Etagere = 0;
            this.Niveau = 0;
            this.Ressources = null;
        }

        public int Travee { get => travee; set => travee = value; }
        public int Etagere { get => etagere; set => etagere = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public List<Ressource> Ressources { get => ressources; set => ressources = value; }
    }
}
