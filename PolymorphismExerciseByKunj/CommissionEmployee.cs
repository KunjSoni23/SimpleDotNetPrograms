using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExerciseByKunj
{
    class CommissionEmployee : Employee
    {

        private double _grossSale;

        public double GrossSale
        {
            get { return _grossSale; }
            set {
                if (value < 0)
                    throw new Exception("Gross Sale cannot be negative.");
                _grossSale = value; 
                }
        }

        private double _commissionRate;

        public double CommissionRate
        {
            get { return _commissionRate; }
            set {
                if (value < 0.0 || value > 1.0)
                {
                    throw new Exception("CommissionRate cannot be greater than 1 or less than 0");
                }
                _commissionRate = value; }
        }

        public CommissionEmployee(int id, EmployeeType typeOfEmployee, string name, double grossSale, double commissionRate) : base( id,  typeOfEmployee,  name)
        {
            GrossSale = grossSale;
            CommissionRate = commissionRate;
        }

        public override double Earnings()
        {
            return GrossSale * CommissionRate;
        }

        public override string ToString()
        {
            return base.ToString() + "\nGrossSale: " + GrossSale.ToString("C")  + "\nCommission Rate: "+ CommissionRate.ToString("P");
        }

    }
}
