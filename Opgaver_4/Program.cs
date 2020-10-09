using System;
using System.Threading;

namespace Opgaver_4 {
    class Program {

        static void Main(string[] args) {
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
        }

        static int ReadInteger() {
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

    public class BankAccount{
        
        public BankAccount (decimal balance) 
        {
            if (balance >= 0) {
                Balance = balance;
            } else {
                throw new InsufficientFundsException();
            }
        }

        public decimal Balance { get; private set; }

        public void Deposit (decimal depositAmount) 
        {
            Balance += depositAmount;
        }

        public void Withdrawl (decimal amount) {
            if (Balance >= amount) {
                Balance -= amount;
            } else {
                throw new InsufficientFundsException();
            }
        }
    }

    public class InsufficientFundsException: Exception { }

    public class GearBox 
    {
        public int CurrentGear { get; set; } = 1;
        public void changeGear(int gear) 
        {
           if(Math.Abs(Math.Abs(CurrentGear) - Math.Abs(gear)) > 1) 
            {
                throw new IllegalGearChangeException("Illegal gear change...");
            }
            CurrentGear = gear;
            Console.WriteLine(gear);
        }
    }

    public class IllegalGearChangeException : Exception 
    {
        public IllegalGearChangeException(string message) : base(message) 
        {
        }
    }

}

