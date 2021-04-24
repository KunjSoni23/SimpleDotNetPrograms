using System;

namespace PolymorphismExerciseByKunj
{
    class Program
    {
        static void Main(string[] args)
        {
            //without polymorphism
            
            SalariedEmployee se1 = new SalariedEmployee(101, EmployeeType.SalariedEmployee, "Kunj", 800);
            
            HourlyEmployee he1 = new HourlyEmployee(102, EmployeeType.HourlyEmployee, "Anna", 35, 15);

            CommissionEmployee ce1 = new CommissionEmployee(103, EmployeeType.CommissionEmployee, "Mark", 10000, 0.15);

            SalaryPlusCommissionEmployee sc1 = new SalaryPlusCommissionEmployee(104, EmployeeType.SalaryPlusCommissionEmployee, "Wood", 5000, 0.005, 800);

            Console.WriteLine(se1);
            Console.WriteLine("Earnings: "+ se1.Earnings().ToString("c"));
            Console.WriteLine();
            Console.WriteLine(he1);
            Console.WriteLine("Earnings: " + he1.Earnings().ToString("c"));
            Console.WriteLine();
            Console.WriteLine(ce1);
            Console.WriteLine("Earnings: " + ce1.Earnings().ToString("c"));
            Console.WriteLine();
            Console.WriteLine(sc1);
            Console.WriteLine("Earnings: " + sc1.Earnings().ToString("c"));

            //with polymorphism

            Employee[] emp = new Employee[3];


        }
    }
}
