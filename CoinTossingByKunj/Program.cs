using System;

namespace CoinTossingByKunj
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int heads=0, tails=0;

            Console.WriteLine("##### Head Or Tails #####");
            Console.WriteLine("\nChoose from below:\n1. Heads\n2. Tails");

            do
            {
                Console.Write("\nMake your Call:");
                int call = int.Parse(Console.ReadLine());

                if (call >= 3 || call <= 0)
                {
                    Console.WriteLine("\nChoose from (1-2)!!!");
                    break;
                }

                //Flip();

                if (Flip())
                {
                    Console.WriteLine("\nIt is Heads!");
                    heads++;
                }
                else
                {
                    Console.WriteLine("\nIt is Tails!");
                    tails++;
                }

                Console.WriteLine("\nHeads: "+ heads + "\t" + "Tails: " + tails);


                Console.WriteLine("\nDo you wan to flip it again: (y/n)");
                ch = Console.ReadLine()[0];

            } while (ch=='y');

            
        }

        static bool Flip()
        {
            Random rnd = new Random();
            return rnd.NextDouble() > 0.5;
            //int result = rnd.Next(0, 2);

            //if (result == 0)
            //{
            //    Console.WriteLine("Heads!");
            //}
            //else
            //{
            //    Console.WriteLine("Tails!");
            //}
        }
    }
}

