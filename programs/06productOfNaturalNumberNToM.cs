using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Problems;

public class ProductOfNaturalNumbersNToM
{
    public static void Run()
    {
        static int ReadNumber()
        {
            Console.WriteLine("Please Enter the Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }


        bool accomplished = true;
        BigInteger product = 1;

        while (accomplished)
        {
            int firstNumber = ReadNumber();
            int secondNumber = ReadNumber();

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First Number cannot be greater than second number");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("Both Numbers cannot be same");
            }
            else
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    product *= i;
                }
                accomplished = false;
            }
        }

        Console.WriteLine($"the product of N and M is {product}");
    }
}