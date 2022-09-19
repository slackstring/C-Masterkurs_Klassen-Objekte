using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_Objekte
{
    public class Hund
    {
        //Eigenschaften
        public string Name { get; set; }
        public int Age { get; set; }
        public string Rasse { get; set; }   
        public string Geschlecht { get; set; }

        //Konstruktor
        public Hund(string name, int age, string rasse, string geschlecht)
        {
            Name = name;
            Age = age;
            Rasse = rasse;
            Geschlecht=geschlecht;
        }
        //methoden
        public void Bellen()
        {
            Console.WriteLine("{0} bellt!", Name);
        }
        public void Fressen()
        {
            Console.WriteLine("{0} frisst!", Name);
        }
    }
}
