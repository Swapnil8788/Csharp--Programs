using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Problems;

public class NaturalNumbersBetweenMAndN
{
    public static void Run()
    {
        static int ReadNumber()
        {
            Console.WriteLine("Please Enter the Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }


        bool accomplished = true;
        // BigInteger product = 1;
        int summation = 0;


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
                    if(i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                        summation += i;
                    }
                    else
                    {
                        // Console.Write($"{i} ");
                    }
                }
                accomplished = false;
            }
        }

        // Console.WriteLine($"the product of N and M is ");
        Console.WriteLine($"Sum of even numbers {summation}");
    }
}