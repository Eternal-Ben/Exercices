using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo_Creation_d_une_liste_simple;

namespace Exo_Creation_d_une_liste_simple
{
    class Depart
    {
        public string Depart()
        {
            // Declaration des variables de la classe Main
            List<string> FicheDePersonne = new List<string>();
            string nom = "Votre nom?",
                   prenom = "Votre prenom?",
                   age = "Votre Age?";

            // Affichage (par index) et récupération des données via la console
            Console.WriteLine($"{nom}");
            FicheDePersonne.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{prenom}");
            FicheDePersonne.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{age}");
            FicheDePersonne.Add(Console.ReadLine());
            Console.Clear();

            //Affichage sur l'ecran console de la liste FicheDePersonne + Index([i = 0, i=<i, index++]). L'indexation apl l'objet reférencé en memoire du même nom dans la liste des variables déclarées
            Console.WriteLine("Bonjour Monsieur, " + FicheDePersonne[1] + " " + FicheDePersonne[0] + ",\nVous avez " + FicheDePersonne[2] + " " + "ans.");

            Console.ReadKey();
        }
            return Depart(d);
    }
    class Program
    {
        static void Main(string[] args)
        {
            string d = new Depart(); //ajouter le bon namespace pour trouver la methode.
            Console.WriteLine(d);
            //return Depart;
        }
    }
}
