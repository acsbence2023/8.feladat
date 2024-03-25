using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatok.Models
{
    public class Adat
    {

      
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public string Orszag { get; set; }
        public string Szakma { get; set; }
        public string Hobbi { get; set; }

        public Adat(string nev, int eletkor, string orszag, string szakma, string hobbi)
        {
            Nev = nev;
            Eletkor = eletkor;
            Orszag = orszag;
            Szakma = szakma;
            Hobbi = hobbi;
        }
        public Adat(string sor)
        {
            var adatok = sor.Split(";");
            Nev = adatok[1];
            Eletkor = Convert.ToInt32(adatok[2]);
            Orszag = adatok[3];
            Szakma = adatok[4];
            Hobbi = adatok[5];
        }
        public override string? ToString()
        {
            return Nev + ", " + Eletkor + ", " + Orszag + ", " + Szakma + ", "+Hobbi;
        }

    }
}
