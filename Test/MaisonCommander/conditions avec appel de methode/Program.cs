using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_avec_appel_de_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = new Accueil;
        }
        class Accueil
        {
            string bienvenu = "Bienvenu en cours d'exo",
                majeur = "Etes vous majeur ?",
                authorisarion = "ok!";
        }
        class Majeur
        {
            bool x = false;
            bool y = true;

            if (!y)
            {
                Console.WriteLine("nononoo majeur");
                return x;
            }
            else
            {
                Console.WriteLine("yesssss majeur");
                return y;
            }
        }
    }
}
