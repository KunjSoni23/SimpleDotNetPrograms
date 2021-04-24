using System;

namespace SalesCommissionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value Chart for Items");
            Console.WriteLine("Item\tValue");
            Console.WriteLine("1\t239.99");
            Console.WriteLine("2\t129.75");
            Console.WriteLine("3\t99.95");
            Console.WriteLine("4\t350.89");

            Console.WriteLine("Enter you Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of item 1 sold by you last week: ");
            int item1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number of item 2 sold by you last week: ");
            int item2 = int.Parse(Console.ReadLine());
            Console.Write("Enter number of item 3 sold by you last week: ");
            int item3 = int.Parse(Console.ReadLine());
            Console.Write("Enter number of item 4 sold by you last week: ");
            int item4 = int.Parse(Console.ReadLine());

            double grossSale = (239.99 * item1) + (129.75 * item2) + (99.95*item3) + (350.89*item4);

            double commission = 200 + (grossSale * 0.09);

            Console.WriteLine("Hi "+ name + ", your Earning for last Week is: $" + String.Format("(0:0.00)",commission));
        }
    }
}
