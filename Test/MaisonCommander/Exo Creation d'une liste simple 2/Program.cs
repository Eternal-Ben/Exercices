using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Creation_d_une_liste_simple
{
    class Program
    {
        public string Usersliste()
        {
            //Creation de la liste des users
            List<string> ListUsers = new List<string>();

            //Creation des variables
            string name = "Votre nom ?",
                   firstname = "Votre prenom ?",
                   age = "Votre age ?",
                   genre = "votre genre ?";

            //traitement de la variable string passé à la console
            Console.WriteLine($"{name}");
            //Ajout des donner fournit par l'utilisateur via console, dans la liste des users.
            ListUsers.Add(Console.ReadLine());
            //On efface tout les affichages precedent de la console
            Console.Clear();

            Console.WriteLine($"{firstname}");
            ListUsers.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{age}");
            ListUsers.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{genre}");
            ListUsers.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Bonjour Monsieur, " + ListUsers[1] + " " + ListUsers[0] + ",\nVous avez " + ListUsers[2] + " " + "ans.");

            //revoir la deff de la fonction return
            return Usersliste();
        }
        public string Keysliste()
        {
            List<string> ListKys = new List<string>();
            string name = "Votre nom ?",
                   rootowner = "Etes vous administrateur ?",
                   number = "Votre clée secrette ?",
                   rootnumber = "Votre mot de passe administrateur ?";

            Console.WriteLine($"{name}");
            ListKys.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{rootowner}");
            var reponse = (Console.ReadLine());
            if (reponse == ("n"))
            {
            Console.WriteLine("Monsieur"+ListKys[0] + "," + "\nVous etes simple utilisateur et non administrateur, retour vers la page d'identification simple.");
            Console.Clear();

            Console.WriteLine($"{number}");
            ListKys.Add(Console.ReadLine());
            Console.Clear();
            }
            ListKys.Add(reponse);
            Console.Clear();

            Console.WriteLine($"{rootnumber}");
            ListKys.Add(Console.ReadLine());
            Console.Clear();


            return Keysliste();
        }

        static void Main(string[] args)
        {
            var u = new Useslistes();
            var k = new Keysliste();
            Console.WriteLine(u + k);
        }

    }
}
