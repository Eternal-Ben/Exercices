using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Creation_d_une_liste_simple
{
    class Discours
    {
        // declaration des variables avec portée sur la class parent uniquement ; Discours
        public string accueil = "Bienvenue sur notre page d'accueil.",
               sortie = "Au revoir et à bientôt.",
               nom = "Votre nom?",
               prenom = "Votre prenom?";

        public string Accueil()
        {
            return accueil;
        }

        public string Sortie()
        {
            return sortie;
        }

        public string Nom()
        {
            return nom;
        }

        public string Prenom()
        {
            return prenom;
        }

    }
}
