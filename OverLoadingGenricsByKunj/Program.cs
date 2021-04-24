using System;

namespace OverLoadingGenricsByKunj
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'h','e','l','l','o'};

            Console.WriteLine("Integer array: ");
            PrintArray<int>(intArray, 1,4);
            Console.WriteLine("\nDouble array: ");
            PrintArray<double>(doubleArray, 1, 4);
            Console.WriteLine("\nChar array: ");
            PrintArray<char>(charArray, 1, 4);
        }

        public static void PrintArray<T>(T[] array, int lowIndex, int highIndex)
        {
            if (lowIndex <= 0 || highIndex <= 0 || lowIndex > array.Length || highIndex > array.Length || lowIndex >= highIndex)
            {
                throw new Exception("This Cannot be possible");
            }
            else
            {
                Console.WriteLine(array[lowIndex]);
                Console.WriteLine(array[highIndex]);
                foreach (T i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

