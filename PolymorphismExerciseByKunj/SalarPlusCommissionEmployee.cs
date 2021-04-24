using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExerciseByKunj
{
    class SalaryPlusCommissionEmployee : CommissionEmployee
    {
        private double _baseSalary;

        public double BaseSalary
        {
            get { return _baseSalary; }
            set { _baseSalary = value; }
        }

        public SalaryPlusCommissionEmployee(int id, EmployeeType typeOfEmployee, string name, double grossSale, double commissionRate, double baseSalary) : base( id,  typeOfEmployee,  name, grossSale, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        public override double Earnings()
        {
            return BaseSalary + (CommissionRate * GrossSale);
        }

        public override string ToString()
        {
            return base.ToString() + "\nBaseSalary: " + BaseSalary;
        }

    }
}
