namespace OOP_opgaver2
{
    class Manager : Employee
    {
        public Manager (string name, string jobTitle, decimal salary, decimal bonus, int level) : 
                        base(name, jobTitle, salary, level) 
        {
            Bonus = bonus;
        }
        public decimal Bonus { get; set; }

        public override decimal CalculateYearlySalary()
        {
            return base.CalculateYearlySalary() + this.Bonus;
            
            //return (Salary * 12) + Bonus;
        }
    }
}

