using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_Objekte
{
    public class Bankkonto
    {
        //Eigenschaften
        public decimal kontostand { get; set; }
        public string besitzer    { get; set; }

        //Methoden
        public void Einzahlen(decimal betrag)
        {
            kontostand += betrag;
            Console.WriteLine("Es wurden {0} EURO eingezahlt.", betrag);
            Console.WriteLine("Neuer Kontostand: {0} EURO.", kontostand);
        }

        public void Auszahlen(decimal betrag)
        {
            kontostand -= betrag;
            Console.WriteLine("Es wurden {0} EURO abgehoben.", betrag);
            Console.WriteLine("Neuer Kontostand: {0} EURO.",kontostand);
        }
    }
}
