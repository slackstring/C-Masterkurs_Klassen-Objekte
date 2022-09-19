using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_Objekte
{
    public class Person
    {
        //Eigenschaften
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //Konstruktor
        public Person (string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        //Methoden
        public void PrintInformation()
        {
            Console.WriteLine("{0} {1}",FirstName,LastName);
            Console.WriteLine(Age);
        }
    }
    public class Teacher : Person
    {
        //Konstruktor
        public Teacher(string firstName, string lastName, int age) : base(firstName,lastName,age)
        {
        }
        //Methoden
        public void Teach()
        {
            Console.WriteLine("Herr/Frau {0} unterrichtet die Klasse!",LastName);
        }
    }

    public class Student : Person
    {   
        //Konstruktor
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }
        //Methoden
        public void ListenToTeacher()
        {
            Console.WriteLine("Der/Die Schüler/in {0} {1} hört dem Lehrer zu!", FirstName, LastName);
        }
    }
    
}
