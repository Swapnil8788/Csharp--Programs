
namespace Problems;

public class OneToNNaturalNumbers
{
    public static void Run()
    {
        static int ReadNum()
        {
            Console.WriteLine("Please enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        int num = ReadNum();
        for (int i = 1; i <= num; i++)
        {
            Console.Write($"{i} ");
        }
        
    }
}