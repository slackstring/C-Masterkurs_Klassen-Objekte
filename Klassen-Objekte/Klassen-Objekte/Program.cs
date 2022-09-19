using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Klassen_Objekte;
using TestNamespace;

namespace Klassenbeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Bankkonto Beispiel
            Bankkonto kto01 = new Bankkonto();
            kto01.kontostand = 2000;
            kto01.besitzer = "Eileen Dapper";
            kto01.Einzahlen(500);
            kto01.Auszahlen(200);
            */

            //Hundeklasse
            /*Hund cooper = new Hund();
            cooper.name = "cooper";
            cooper.age = 8;
            cooper.rasse = "Sharpei";
            cooper.geschlecht = "männlich";
            cooper.Bellen();
            cooper.Fressen();*/

            /*Hund maya = new Hund("maya",7,"Boxer","weiblich");
            maya.Bellen();
            maya.Fressen();
            */

            //Statische Klasse Fläche berechnen
            /* Console.WriteLine("Dreieck:" + AreaCalculator.GetTriangleArea(5, 12));
             Console.WriteLine("Rechteck:" + AreaCalculator.GetRectangleArea(10, 4));
             Console.WriteLine("Quadrat:" + AreaCalculator.GetSquareArea(4));
             Console.WriteLine("Kreis:" + AreaCalculator.GetCircleArea(10));
             */

            //Klasse Person mit Vererbung
            Person[] peopleInClassroom = new Person[5];
            peopleInClassroom[0] = new Teacher("John", "Smith", 32);
            peopleInClassroom[1] = new Student("Sabrina", "Müller", 18);
            peopleInClassroom[2] = new Student("Anna", "Matt", 17); 
            peopleInClassroom[3] = new Student("Peter", "Fredl", 18);
            peopleInClassroom[4] = new Student("Mathias", "Maier", 19);

            foreach (Person p in peopleInClassroom)
            {
                p.PrintInformation(); 
                if(p is Teacher)
                {
                    (p as Teacher).Teach();
                }
                if(p is Student)
                {
                    (p as Student).ListenToTeacher();
                }
            }


            Console.ReadKey();
        }
    }
}