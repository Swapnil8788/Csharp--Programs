
namespace Problems;

public class ReadingNumberOfDay
{
    public static void Run()
    {
        static int ReadDay()
        {
            Console.Write("Please Enter the day: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            return dayNumber;
        }

        int day = ReadDay();
        
        switch (day)
        {
            case 0:
                Console.WriteLine("Monday");
                break;
            case 1:
                Console.WriteLine("TuesDay");
                break;
            case 2:
                Console.WriteLine("WednesDay");
                break;
            case 3:
                Console.WriteLine("ThurseDay");
                break;
            case 4:
                Console.WriteLine("Friday");
                break;
            case 5:
                Console.WriteLine("Saturday");
                break;
            case 6:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Please enter a valid day number");
                break;
            
        }
    }
}