using System;

namespace LesConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            string sQuestion = "Entrer votre age",
                   sMajeur = "Vous êtes majeur",
                   sMineur = "Vous êtes mineur",
                   sChrist = "et avez depassé l'esperence de vie du Christ, Bravo !";

            Console.WriteLine($"{sQuestion}");
            int iAge = int.Parse(Console.ReadLine());
            int iAgeChrist = 30,
                iAgeMajeur = 18;

            if (iAge > iAgeChrist)
            {
                Console.WriteLine(($"{sMajeur}") + ($"{sChrist}"));
            }
            else if (iAge >= iAgeMajeur)
            {
                Console.WriteLine($"{sMajeur}");
            }
            else
            {
                if (iAge < iAgeMajeur)
                    Console.WriteLine($"{sMineur}");
            }
            Console.ReadKey(true);
        }
    }
}