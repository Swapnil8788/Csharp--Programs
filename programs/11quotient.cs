namespace Problems;

public class Quotient
{
    public static void Run()
    {
        static double ReadNumber()
        {
            Console.WriteLine("Please Enter the Number: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        double divident = ReadNumber();
        double divisor = ReadNumber();

        int quotient = 0;
        while(divident - divisor >= 0)
        {
            divident -= divisor;
            quotient += 1;
        }


        Console.WriteLine($"so the quotient will be without using / operator {quotient}");

        // Console.WriteLine($"so the number quotient will be {divident / divisor}");
        // Console.WriteLine($"the remainder will be {divident % divisor}");
        
    }
}