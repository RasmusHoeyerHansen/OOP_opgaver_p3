using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PersonPrinter
    {
        public void PrintFamilyTree(Person person)
        {
            PrintPerson(person);
            if (person.Far != null)
            {
                PrintFamilyTree(person.Far);
            }
        }

        private void PrintPerson(Person person)
        {
            // Console.WriteLine($"{person.Fornavn}");
            Console.WriteLine(person);
        }
    }
}
