namespace Problems;

public class AnyTableWithoutMultiplicationOperator
{
    public static void Run()
    {
        static int ReadNumber()
        {
            Console.WriteLine("Please Enter the Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        int tableNumber = ReadNumber();

        int number = 0;

        for (int i = 1; i <= 10; i++)
        {
            number += tableNumber;
            Console.WriteLine($"{tableNumber} * {i} = {number}");
        }

        

    }
}