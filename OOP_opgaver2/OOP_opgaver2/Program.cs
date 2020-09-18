using System;
using System.Diagnostics;

namespace OOP_opgaver2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Manager manager = new Manager("Lars Veber", "CEO", 1001.1m, 500m, 10);
           //Employee employee = new Employee("Tommy Hansen", "fra HR", 200.2m, 4);
           //Console.WriteLine(manager.Name + " tjener " + Convert.ToString(manager.CalculateYearlySalary()));
           //Console.WriteLine(employee.Name + " " + employee.JobTitle + " tjener " + Convert.ToString(employee.CalculateYearlySalary()));

            WeekdayPM wpm = new WeekdayPM(2);
            wpm.InsertCoin(10);
            Console.WriteLine(wpm.calcMinutes());

            WeekendPM weekendPM = new WeekendPM(1);
            weekendPM.InsertCoin(10);
            Console.WriteLine(weekendPM.calcMinutes());

            BankAccount BA = new BankAccount();
            BA.Deposit(2500);
            Console.WriteLine(BA.Balance);
            BA.Withdraw(3000);
            Console.WriteLine(BA.Balance);
        }
    }
    public class BankAccount
    {
        public decimal Balance { get; private set; }
        private decimal BorrowingRate { get; set; }
        private decimal SavingsRate { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance - amount >= 0)
                Balance -= amount;
            else
                throw new ArgumentOutOfRangeException("Do har ingn pæng', din pong!");
        }
    }


}

