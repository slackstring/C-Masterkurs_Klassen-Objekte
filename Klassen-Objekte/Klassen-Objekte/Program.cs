using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Klassen_Objekte;

namespace Klassenbeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankkonto kto01 = new Bankkonto();
            kto01.kontostand = 2000;
            kto01.besitzer = "Eileen Dapper";
            kto01.Einzahlen(500);
            kto01.Auszahlen(200);

            Console.ReadKey();
        }
    }
}