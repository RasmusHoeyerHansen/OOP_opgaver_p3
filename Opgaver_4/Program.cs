using System;
using System.Security.Cryptography;
using System.Threading;

namespace Opgaver_4
{
    class Program 
    {

        static void Main(string[] args) 
        {
            //Console.WriteLine("Input something...");
            //Console.WriteLine(ReadInteger());
            //while (true) {
            //    string i = Console.ReadLine();
            //    try {
            //        int.Parse(i);
            //    } catch (Exception) {
            //        Console.WriteLine("LOL YOU FAILED!");
            //    }
            //}

            //BankAccount niels = new BankAccount(10);
            //Console.WriteLine(niels.Balance);
            //niels.Withdrawl(15);
            //Console.WriteLine(niels.Balance);
            //Console.Read();
            /*
            GearBox car = new GearBox();
            try {
                car.changeGear(-1);
                car.changeGear(1);
                car.changeGear(5);
                Console.WriteLine(car.CurrentGear);

                Console.ReadLine();

            } catch (Exception e) {
                car.changeGear(1);
                Console.WriteLine(car.CurrentGear);
            }
            */

            PrinterFromHELL p = new PrinterFromHELL();

            while (true)
            {
                try
                {
                    p.print();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    if (Console.ReadLine()== "ok")
                    {
                        continue;
                    };
                }
            }

        }


        public class PrinterFromHELL
        {
            Random r = new Random();
            public void print()
            {
                int x = r.Next(1, 4);

                try
                {
                    switch (x)
                    {
                        case 1:
                            throw new OutOfPaperException("I have nothing to print on");
                        case 2:
                            throw new OutOfTonerException("I have nothing to print with");
                        case 3:
                            throw new PaperJamException("I cannot print");
                        case 4: 
                        default:
                            break;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }


        static int ReadInteger() 
        {
            string input = Console.ReadLine();
            int parsed;
            try {
                parsed = int.Parse(input);
                return parsed;
            } catch (System.FormatException e) {
                Console.WriteLine("Wrong input type" + e);
                return ReadInteger();
            }
        }
    }
}

