using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBiblioteque
{
    public class Revue : Ressource
    {
        private int numeroVolume;
        private DateTime dateParution;

        public Revue(int numeroVolume, DateTime dateParution, string titre, int caution, Emplacement emplacement) : base(titre, caution, emplacement)
        {
            this.numeroVolume = numeroVolume;
            this.dateParution = dateParution;
        }

        public Revue()
        {
            this.numeroVolume = 0;
            this.dateParution = new DateTime();
        }

    }
}
