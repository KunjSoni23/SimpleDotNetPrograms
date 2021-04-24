using System;
using System.Collections.Generic;
using System.Text;

namespace CommissionBaseByKunj
{
    class SalaryPlusCommissionEmployee : CommissionEmployee
    {

        private decimal _salary;


        public decimal Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public SalaryPlusCommissionEmployee(int id, string name, decimal grossSales, decimal commissionRate, decimal salary) : base(id, name, grossSales, commissionRate)
        {
            Salary = salary;
        }

        

        public new decimal Earnings()
        {
            return Salary + base.Earnings();
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalary: " + Salary;
        }

    }
}
