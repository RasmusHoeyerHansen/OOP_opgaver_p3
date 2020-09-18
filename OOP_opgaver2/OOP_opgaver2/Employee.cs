namespace OOP_opgaver2
{
    class Employee
    {
        public Employee(string name, string  jobTitle, decimal salary, int level)
        {
            Name = name;
            JobTitle = jobTitle;
            Level = level;
            Salary = salary + (salary * level/100);
        }

        public string Name { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public int Level { get; set; }

        public virtual decimal CalculateYearlySalary()
        {
            return Salary * 12;
        }
    }
}

