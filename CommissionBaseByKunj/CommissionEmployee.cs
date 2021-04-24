using System;
using System.Collections.Generic;
using System.Text;

namespace CommissionBaseByKunj
{
    class CommissionEmployee
    {
        //fields
        private int _id;
        private string _name;
        private decimal _grossSales;
        private decimal _commissionRate;

        ////parameterless Constructor
        //public CommissionEmployee()
        //{
        //    _id = 0;
        //    _name = null;
        //    _grossSales = 0.0M;
        //    _commissionRate = 0.0M;
        //}

        //constructor with parameters
        public CommissionEmployee(int id,string name,decimal grossSales,decimal commissionRate)
        {
            _id = id;
            _name = name;
            _grossSales = grossSales;
            _commissionRate = commissionRate;
        }

        //getter and setters using property
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal GrossSales
        {
            get => _grossSales;
            set => _grossSales = value;
        }

        public decimal CommissionRate
        {
            get => _commissionRate;
            set => _commissionRate = value;
        }


        public decimal Earnings()
        {
            return GrossSales * CommissionRate;
        }

        public override string ToString()
        {
            return "Employee Id: " + Id + "\n" + "Employee name: " + Name + "\nGross Sale: " + GrossSales + "\nCommissionRate: " + CommissionRate;
        }


    }
}
