﻿//Diag de classe UML, voir les acces et relations induites
/* 
 Ecrire la classe Email
 Ecrire la classe piece jointe (la classe FileInfo est une classe.Net dans l'espace de nom System.IO
 */


using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO;



namespace Mail

{
    public class Email

    {
        public string Sujet { get; set; }

        public string Destinataire { get; set; }

        public string [] DestinatairesEnCopie { get; set; }

        public string Contenu { get; set; }

        public List<PieceJointe> Email.PieceJointe { get; set; } //liste infini

//        public PieceJointe PieceJointe { get; set; } // pas de liste

    }

}