using System;
using System.Collections.Generic;
//using System.Linq;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listUsers = new List<string> { "Alex", "Thierry", "Felipe" },
                         listKeys = new List<string> { "root", "toor", "admin" };

            bool key = Convert.ToBoolean(listKeys), // verif methode de convertsur bool et string ou convertion d'autre type...
                 user = Convert.ToBoolean(listUsers),
                 pass = key && user,
                 quitter = "q" is "Q";

            var date = DateTime.Now;

            string aurevoir = "\nEn souhaitant vous revoir très prochainement, à tres bientôt !",
                   administrateur = "acme@gmail.com",
                   peche = "\nAllons pêcher ça faisait un moment que ça me trotte dans la tete .!",
                   armoir = "\nAller qu'est ce qu'il y a dans cette armoire...",
                   mdp = Console.ReadLine(),
                   presentation = Console.ReadLine(),
                   personalKey = "root",
                   nom = $"\n{date}\nVous êtes dans un espace privé, veuillez préciser votre prénom je vous pries :",
                   bienvenu = $"\nBienvenu {presentation}, veuillez entrez votre mot de passe {date}:",
                   denicherb = "\nDennicher de bonnes affaire ? Oui tout de suite.",
                   souhait = $"\n\nQue souhaitez vous réaliser aujourd'hui {presentation}?",
                   interdiction = $"\n\aVous n'êtes pas autoriser à acceder à ce site, veuillez prendre contact avec notre administrateur, {administrateur}!";
        }
        string Message() // refac en class et recup les declarations d'objet adequat
        {
            var menu = new Menu();
            Console.Clear();
            Console.WriteLine($"{nom}", + $"{bienvenu}");

            if (Convert.ToBoolean(nom) != pass)
            {
                Console.WriteLine($"{interdiction}");
                Console.WriteLine("");
                Console.WriteLine($"\n{date}");
                Console.ReadKey();
            }
            else
            {
                return menu;
            }
        }

        string Menu() // refac en class
        {
                Console.Clear();
                Console.Beep(3000, 90);
                Console.Beep(3900, 90);
                Console.Beep(4100, 190);
                Console.WriteLine($"{bienvenu}");

                Console.Clear();
                Console.WriteLine($"{souhait}");
                Console.WriteLine("1 . Visualiser : 1"); // faire une liste de consultation de client et de voyage en mode sql
                Console.WriteLine("2 . Dénicher   : 2"); // idem ci dessus liste de voyage en dispo avec liste de client acheteur
                Console.WriteLine("3 . Prospecter : 3"); // liste client potentiel et voyage dispo avec promo enfant 12 ans et liste tranche d'age etc via sql ?
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(".qQ : Revenir un peux plus tard finalement... : Qq..");
                Console.WriteLine("");
                Console.WriteLine("");

                int choixMenu = Console.Read();
                switch (choixMenu)
                {
                    case 1:
                        Console.WriteLine($"{armoir}");
                        //new LeVoyage();
                        Voyage.menu(); // attention au "static" dans la methode, menu.
                                       /* var monobjet = new Voyage(); // instancier "minobjet" pour la creation */
                        break;
                    case 2:
                        Console.WriteLine($"{denicherb}");
                        break;
                    case 3:
                        Console.WriteLine($"{peche}");
                        break;
                    case 4 when "q" is "Q":

                    default:
                        Console.WriteLine($"{aurevoir}");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine($"\n{date}");
                        break;
                }
            }

        }
    }
}