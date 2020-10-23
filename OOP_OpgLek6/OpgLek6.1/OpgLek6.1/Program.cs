using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace OpgLek6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            HandyMethodz handyDandy = new HandyMethodz();

            List<string> liste = new List<string>()
            {
                "Hej",
                "Hallo",
                "Bonjour",
                "Halt"
            };

            HandyMethodz.Max(liste);

            int[] a1 = {1,2,3,4,5,6,7,8};
            int[] a2 = {1,6,8,4,3,2,5,7};
      
            
            HandyMethodz.Copy(a1, a2);
            HandyMethodz.Shuffle(a2);

            Console.WriteLine(handyDandy.Min(liste));
            foreach (var item in a2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
