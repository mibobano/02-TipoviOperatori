using System;

namespace CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba janko = new Student();
            
            Osoba osoba = new Osoba();
            if (janko is Osoba)
            {
                Console.WriteLine("je");
            }
            else
                Console.WriteLine("nije");


            Console.ReadKey();
        }
    }
}
