﻿/*Ecrire une classe personne qui contiendra les variable nom, prenom, et age
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personne
{
    private static void Main(string[] args)
    {
        var personne = new Personne();
    }
    public class Personne
    {           // ci dessous les créations des variables, nom, prenom, age, declarées visible par d'autres systemes en dehors du systeme...
        public string nom;
        public string prenom;
        public int age;
    }

}
