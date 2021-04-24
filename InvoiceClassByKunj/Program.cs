using System;

namespace InvoiceClassByKunj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity of item: ");
            int qt = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of item: ");
            decimal pr = decimal.Parse(Console.ReadLine());

            Invoice i = new Invoice("ABC2001", "PS5", qt,pr);

            if (qt < 0)
            {
                Console.WriteLine("You can not enter the negative quantity");
            }
            else if (pr < 0.0M)
            {
                Console.WriteLine("You can not enter the negative quantity");
            }

            else
            {

                Console.WriteLine("Total amount is : " + i.GetInvoiceAmount(i.Quantity,i.Price).ToString("C"));
            }
        }
    }
}
