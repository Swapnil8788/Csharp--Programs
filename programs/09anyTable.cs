namespace Problems;

public class AnyTable
{
    public static void Run()
    {
        static int ReadNumber()
        {
            Console.WriteLine("Please Enter the Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        int tableNumber = ReadNumber();

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{tableNumber} * {i} = {i * tableNumber}");
        }

    }
}