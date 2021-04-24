using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExerciseByKunj
{
    public class SalariedEmployee : Employee
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public SalariedEmployee(int id, EmployeeType typeOfEmployee, string name, double salary) : base( id,  typeOfEmployee,  name)
        {
            Salary = salary;
        }

        public override double Earnings()
        {
            return Salary;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalary: "+ Salary.ToString("C");
        }



    }
}
