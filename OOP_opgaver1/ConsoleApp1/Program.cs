using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laver ny person
            Person person1 = new Person();
            //Sætter fornavn
            person1.Fornavn = "Joakim";

            //person 3 med fornavn Peter
            Person person3 = new Person
            {
                Fornavn = "Peter"
            };

            //Person2 med far person3
            Person person2 = new Person(person3);
            person2.Fornavn = "Sylvester";

            //consolewrite med person1 fornavn
            Console.WriteLine(person1.Fornavn);

            //writeline med tostring metode
            Console.WriteLine(person1);

            person1.Far = person2;
            person2.Far = person3;
            Console.WriteLine("{0}'s far: {1} og bedstefar: {2}", 
                person1.Fornavn, person1.Far.Fornavn, person1.Far.Far.Fornavn);

            //Ny printer
            PersonPrinter printer = new PersonPrinter();
            //Kald af PrintFamilyTree
            printer.PrintFamilyTree(person1);

            
        }
    }
}
