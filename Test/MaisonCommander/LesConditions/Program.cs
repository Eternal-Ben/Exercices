using System;

namespace La_Condition_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            // intitialisation du boolean non avec une valeure à false
            // bool non = false;

            Console.WriteLine("Etes vous majeur ?");
            // bool reponse = Convert.ToBoolean(Console.ReadLine());
            var reponse = Console.ReadLine();
            string non = "non";


            //Condition if else voir meme if aurait out etre apliqué ici...
            if (non == reponse)
            {
                Console.WriteLine("Désolé mon enfant, tu n'es pas majeur. A bientôt.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Bienvenu !");
                Console.ReadKey();
            }
                Console.Clear();
        }
    }
}

// * declaration des vaeriables en var et en string plutôt quand boolean pour simplifier le code ; à tester une fois reconnecté au net.