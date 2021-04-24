using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double grossPay1,grossPay11, grossPay2,grossPay21, grossPay3,grossPay31;

            double total1, total2, total3;

            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("--------------------SALARY CALCULATOR---------------------");
            Console.WriteLine("----------------------------------------------------------\n");
            
            Console.Write("Enter Name of First Employee: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter Number of Hours you worked: ");
            double nohrs1 = double.Parse(Console.ReadLine());
            Console.Write("Enter houtly rate of each employee: ");
            double rate1 = double.Parse(Console.ReadLine());

            if(nohrs1 < 40.0 && nohrs1 > 0.0)
            {
                grossPay1 = nohrs1 * rate1;

                Console.WriteLine(name1 + ", your salary is: " + grossPay1.ToString("C"));

            }
            if (nohrs1 > 40.0)
            {
                grossPay1 = 40 * rate1;
                grossPay11 = (nohrs1 - 40) * rate1 * 1.5;

                total1 = grossPay1 + grossPay11;

                Console.WriteLine(name1 + ", your salary is: "+ total1.ToString("c"));
            }

            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------\n");

            Console.Write("Enter Name of Second Employee: ");
            string name2 = Console.ReadLine();
            Console.Write("Enter Number of Hours you worked: ");
            double nohrs2 = double.Parse(Console.ReadLine());
            Console.Write("Enter houtly rate of each employee: ");
            double rate2 = double.Parse(Console.ReadLine());

            if (nohrs2 < 40.0 && nohrs2 > 0.0)
            {
                grossPay2 = nohrs2 * rate2;

                Console.WriteLine(name2 + ", your salary is: " + grossPay2.ToString("c"));

            }
            if (nohrs2 > 40.0)
            {
                grossPay2 = 40 * rate2;
                grossPay21 = (nohrs2 - 40) * rate2 * 1.5;

                total2 = grossPay2 + grossPay21;

                Console.WriteLine(name2 + ", your salary is: " + total2.ToString("c"));
            }

            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------\n");

            Console.Write("Enter Name of Third Employee: ");
            string name3 = Console.ReadLine();
            Console.Write("Enter Number of Hours you worked: ");
            double nohrs3 = double.Parse(Console.ReadLine());
            Console.Write("Enter houtly rate of each employee: ");
            double rate3 = double.Parse(Console.ReadLine());

            if (nohrs3 < 40.0 && nohrs3 > 0.0)
            {
                grossPay3 = nohrs3 * rate3;

                Console.WriteLine(name3 + ", your salary is: " + grossPay3.ToString("c"));

            }
            if (nohrs3 > 40.0)
            {
                grossPay3 = 40 * rate3;
                grossPay31 = (nohrs3 - 40) * rate3 * 1.5;

                total3 = grossPay3 + grossPay31;

                Console.WriteLine(name3 + ", your salary is: " + total3.ToString("c"));
            }

        }
    }
}

