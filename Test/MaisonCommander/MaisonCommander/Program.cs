using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            var FicheDePersonne = new List<string>();
            string nom = "Votre nom ?",
                   prenom = "Votre prenom?",
                   age = "Votre Age?";

            Console.WriteLine($"{nom}");
            FicheDePersonne.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{prenom}");
            FicheDePersonne.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"{age}");
            FicheDePersonne.Add(Console.ReadLine());
            Console.Clear();
            // FicheDePersonne+[index] >> [] l'index apl l'objet referencé dans la la liste
            Console.WriteLine("Bonjour Monsieur, " + FicheDePersonne[1] + " " + FicheDePersonne[0] + ",\nVous avez " + FicheDePersonne[2] + " " + "ans.");

            Console.ReadKey();
        }
    }
}
