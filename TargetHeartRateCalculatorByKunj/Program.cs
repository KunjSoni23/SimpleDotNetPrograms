using System;

namespace TargetHeartRateCalculatorByKunj
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("############## Target Heart Rate Calculator ##############\n");

            Console.Write("Enter the First Name    : ");
            string fname = Console.ReadLine();

            Console.Write("Enter the Last Name     : ");
            string lname = Console.ReadLine();

            Console.Write("Enter you Date of Birth : ");
            int dob = int.Parse(Console.ReadLine());


            Console.Write("Enter Current Year      : ");
            int cy = int.Parse(Console.ReadLine());


            HeartRates hr = new HeartRates(fname,lname, dob,cy);

            Console.WriteLine("\nAge of {0} {1} is {2}.\n",hr.FirstName,hr.LastName,hr.CalculateAge(hr.YearOfBirth,hr.CurrentYear));

            Console.WriteLine("Maximum heart rate is: " + hr.MaxiHeartRate(hr.CalculateAge(hr.YearOfBirth,hr.CurrentYear)) + "\n");

            Console.WriteLine("Target Heart-rate Range is: "+hr.TargetHeartRate(hr.CalculateAge(hr.YearOfBirth, hr.CurrentYear)) + "\n");
        }
    }
}
