namespace Problems;

public class CountTheNumbers
{
    public static void Run()
    {
        // int n = 12345;
        // n = Math.Abs(n);

        // int lengthOfNumber = n.ToString().Length;

        // int count = 0;
        // do
        // {
        //     count++;
        //     n /= 10;
        // } while(n > 0);

        // Console.WriteLine($"so the by string method is {lengthOfNumber} and by mathematical way is {count}");


        static int ReadNumber()
        {
            Console.WriteLine("Please Enter the Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        int n = ReadNumber();
        int rev = 0;

        while (n > 0)
        {
            int digit = n % 10;
            rev = rev * 10 + digit;
            n /= 10;
        }

        Console.WriteLine(rev); // 4321
        Console.WriteLine($"int min value is {int.MinValue} and max value is {int.MaxValue}");

    }
}