using System;

namespace CommissionBaseByKunj
{
    class Program
    {
        static void Main(string[] args)
        {
            CommissionEmployee c = new CommissionEmployee(101, "John", 10000, 0.12M);

            Console.WriteLine("Commission Employee's Info\n");
            Console.WriteLine(c);
            Console.WriteLine($"\nEarnings: {c.Earnings():C}");



            SalaryPlusCommissionEmployee s = new SalaryPlusCommissionEmployee(102, "Anna", 10000M, 0.08M, 500M);

            Console.WriteLine("\n\nSalary Plus Commission Employee's Info\n");
            Console.WriteLine(s);
            Console.WriteLine($"\nEarnings: {s.Earnings():C}");

        }
    }
}
