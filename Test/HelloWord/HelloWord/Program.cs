/* Première application "Hello Word !"
Utilisation des Methodes ;
  Console.WriteLine(ce que l'on souhaite afficher) : permet l'affichage du résultat demandé à la console
  Console.Readkey(...) & Console.ReadLine(...)     : permet à la console de recuperer 'la ligne || la touche' tapé par l'utilsateur
*/

using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string aurevoir = "\nEn souhaitant vous revoir très prochainement, à tres bientôt !",
                   administrateur = "acme@gmail.com",
                   peche = "\nAllons pêcher ça faisait un moment que ça me trotte dans la tete .!",
                   armoir = "\nAller qu'est ce qu'il y a dans cette armoire...";

            var presentation = Console.ReadLine();
            var date = DateTime.Now;
            var nom = $"\n{date}\nVotre identifiant qui est votre prenom, je vous pries :";
            var bienvenu = $"\nBienvenu {presentation}, veuillez entrez votre mot de passe {date}:";
            var mdp = Console.ReadLine();
            var denicherb = "\nDennicher de bonnes affaire ? Oui tout de suite.";
            var souhait = $"\n\nQue souhaitez vous réaliser aujourd'hui {presentation}?";
            var interdiction = $"\n\aVous n'êtes pas autoriser à acceder à ce site, veuillez prendre contact avec notre administrateur, {administrateur}!";
            List<string> clees = new List<string> {"root","toor","UserCom" };
            List<string> users = new List<string> { "Alex", "Thierry", "Felipe"};

            bool quitter = "q" is "Q";


            Console.WriteLine($"{nom}");
            var key = "root";
            foreach (string clee in clees)
                if (clee == key)
                    foreach (string user in users)

                        if (nom != user)
                        {
                            Console.Clear();
                            Console.WriteLine($"{interdiction}");
                            Console.WriteLine("");
                            Console.WriteLine($"\n{date}");
                            Console.ReadKey();
                        }
                        else
                        {

                            Console.Clear();
                            Console.Beep(3000, 90);
                            Console.Beep(3900, 90);
                            Console.Beep(4100, 190);
                            Console.WriteLine($"{bienvenu}");
                        }
                        {
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
                                case 4 when "q"is "Q":

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