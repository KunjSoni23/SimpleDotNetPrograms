using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExerciseByKunj
{

    public enum EmployeeType
    {
        SalariedEmployee, HourlyEmployee, CommissionEmployee, SalaryPlusCommissionEmployee
    }
    public abstract class Employee
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private EmployeeType _typeOfEmployee;

        public EmployeeType TypeOfEmployee
        {
            get { return _typeOfEmployee; }
            set { _typeOfEmployee = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Employee(int id, EmployeeType typeOfEmployee, string name)
        {
            Id = id;
            TypeOfEmployee = typeOfEmployee;
            Name = name;
        }

        public abstract double Earnings();

        public override string ToString()
        {
            return "Employee ID: "+ Id + "\nEmployee Name: " + Name + "\nEmployee Type: " + TypeOfEmployee;
        }

    }
}
 