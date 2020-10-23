using System;

namespace OpgLek6._2
{
    class Program
    {
        static void Main(string[] args)
        {
             Pair<int,int> pair = new Pair<int,int>(40, 45);

            Pair<int,int> newPair = pair.Swap();
            Console.WriteLine(newPair.Value1 + " " + newPair.Value2);

            Pair<bool, string> pair2 = new Pair<bool, string>(true, "Hejsa");


            //Pair<string, int> newPair2 = pair2.Swap();
            //Console.WriteLine(newPair2.Value1 + " " + newPair2.Value2);

            Pair<bool, int> newPair3 = pair2.SetSnd(42);
            Console.WriteLine(newPair3.Value1 + " " + newPair3.Value2);

        }
    }
}
