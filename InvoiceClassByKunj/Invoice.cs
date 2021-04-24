using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceClassByKunj
{
    class Invoice
    {
        private string _number;
        private string _name;
        private int _quantity;
        private decimal _price;


        //_number;
        //    _name;
        //    _quantity;
        //    _price

        public Invoice()
        {
            _number = null;
            _name = null;
            _quantity = 0;
            _price = 0.0M;
        }

        public Invoice(string number, string name, int quantity, decimal price)
        {
            _number = number;
            _name = name;
            _quantity = quantity;
            _price = price;
        }

        public int Quantity{
            get => _quantity;
            set => _quantity = value;
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public decimal GetInvoiceAmount(int quantity, decimal price)
        {
            return quantity * price;
        }
        

    }
}
