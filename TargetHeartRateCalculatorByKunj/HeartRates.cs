using System;
using System.Collections.Generic;
using System.Text;

namespace TargetHeartRateCalculatorByKunj
{
    class HeartRates
    {
        private string _firstName;
        private string _lastName;
        private int _yearOfBirth;
        private int _currentYear;

        public HeartRates()
        {
            _firstName = null;
            _lastName = null;
            _yearOfBirth = 0;
            _currentYear = 0;
        }

        public HeartRates(string firstName, string lastName, int yearOfBirth, int currentYear)
        {
            _firstName = firstName;
            _lastName = lastName;
            _yearOfBirth = yearOfBirth;
            _currentYear = currentYear;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public int YearOfBirth
        {
            get => _yearOfBirth;
            set => _yearOfBirth = value;

        }

        public int CurrentYear
        {
            get => _currentYear;
            set => _currentYear = value;
        }

        public int CalculateAge(int yearOfBirth, int currentYear)
        {
            int age;
            age = currentYear - yearOfBirth;
            return age;
        }

        public string MaxiHeartRate(int age)
        {
            return (220 - age) + "bpm";
        }

        public string TargetHeartRate(int age)
        {
            int maxHeart = 220 - age;

            int lowRange = (50 * maxHeart)/100;

            int highRange = (85 * maxHeart) / 100;

            return lowRange + "-" + highRange + "bpm";

        }
    }
}