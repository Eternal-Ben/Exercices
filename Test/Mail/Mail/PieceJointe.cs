using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mail

{
    static void Main(string[] args)
    {
        Mail + 1 = new PieceJointe; 
    }

    public class PieceJointe

    {
        public Email Email { get; set; }

        public DateTime DateAjout { get; set; }

        public List<FileInfo> Files { get; set; }

    }
    public class Email
    {
        public DateTime DateAjout { get; set; }

        public List<Email> Emails { get; set; }
    }
    public class DateTime
    {
        public DateTime DateAjout { get; set; }
    }
    public class Files
    {

    }

}