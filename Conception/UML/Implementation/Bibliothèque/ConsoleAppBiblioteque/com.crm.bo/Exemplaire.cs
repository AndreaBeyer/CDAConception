using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBibliothequeNameSpace
{
    public class Exemplaire
    {
        private string codeBarre;
        private DateTime dateRetour;
        private Ressource ressource;
        private Utilisateur actualUtilisateur;

        public Exemplaire(string codeBarre, DateTime dateRetour, Ressource ressource, Utilisateur actualUtilisateur)
        {
            this.codeBarre = codeBarre;
            this.dateRetour = dateRetour;
            this.ressource = ressource;
            this.ActualUtilisateur = actualUtilisateur;
        }

        public Exemplaire()
        {
            this.codeBarre = null;
            this.dateRetour = new DateTime();
            this.ressource = null;
            this.ActualUtilisateur = null;
        }

        public string CodeBarre { get => codeBarre; set => codeBarre = value; }
        public DateTime DateRetour { get => dateRetour; set => dateRetour = value; }
        public Ressource Ressource { get => ressource; set => ressource = value; }
        public Utilisateur ActualUtilisateur { get => actualUtilisateur; set => actualUtilisateur = value; }
    }
}
