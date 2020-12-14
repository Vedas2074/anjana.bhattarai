using System;
using System.Linq;

namespace AccessModifierAndMethods
{
    class Methods
    {
        void PrintInfo()
        {
            Console.WriteLine("Printing something...");
            Multiply(23.5f, 2234.567f);

            Sum(2.3, 45.1);
            Sum(2.3, 45.1, 12.89);

            Greet("Bishnu", "Mr.");
            Greet("Sarita");

            byte[] numbers = { 2, 4, 6, 7, 12, 234, 56, 78 };
            (byte Min, byte Max) result = FindMinMax(numbers);

            // Named arguments
            PrintCustomerDetails(age: 23, name: "Bishnu", isMale: true, address: "Ktm");
        }

        void PrintSomething(string message)
        {
            Console.WriteLine(message);
        }

        float Multiply(float firstNum, float secondNum)
        {
            float product = firstNum * secondNum;
            return product;
        }

        // Variable number of arguments
        double Sum(params double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum = sum + num;
            }

            return sum;
        }

        // Optional arguments
        string Greet(string name, string prefix = "Miss.")
        {
            string fullName = $"{prefix}, {name}"; //string interpolation
            return fullName;
        }

        //Returning multiple values : using tuples
        (byte, byte) FindMinMax(byte[] numbers)
        {
            byte max = numbers.Max();
            byte min = numbers.Min();

            return (min, max);
        }

        void PrintCustomerDetails(string name, string address, byte age, bool isMale)
        {
            Console.WriteLine($"{name}[{age}], {address}");
        }

        //Expression bodied method syntax
        float Subtract(float firstNum, float secondNum) => firstNum - secondNum;
    }
}