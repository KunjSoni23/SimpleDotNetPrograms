using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExerciseByKunj
{
    class HourlyEmployee : Employee
    {
        private double _noOfHours;

        public double NoOfHours
        {
            get { return _noOfHours; }
            set { _noOfHours = value; }
        }


        private double _wage;

        public double Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        public HourlyEmployee(int id, EmployeeType typeOfEmployee, string name, double noOfHours, double wage) : base(id, typeOfEmployee, name)
        {
            NoOfHours = noOfHours;
            Wage = wage;
        }

        public override double Earnings()
        {
            if (NoOfHours <=  40)
            {
                return NoOfHours * Wage;
            }
            else
            {
                return ((NoOfHours - 40) * 1.5 * Wage) + (40 * Wage);
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nNo. Of Hours: " + NoOfHours + "\nWage: " + Wage;
        }

    }
}
