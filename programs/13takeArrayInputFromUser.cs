namespace Problems;

public class TakeInputFromUserForArray
{
    public static void Run()
    {
        static int ReadNumber()
        {
            Console.WriteLine("Please Enter the Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        int[] userInputs = new int[3];
        // userInputs[0] = ReadNumber();
        // userInputs[1] = ReadNumber();
        // userInputs[2] = ReadNumber();

        for (int i = 0; i < userInputs.Length; i++)
        {
            userInputs[i] = ReadNumber();
        }

        foreach (var item in userInputs)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine("List follows");

        List<int> listUserInputs = new List<int>();
        int userInputCount = ReadNumber();
        for (int i = 0; i < userInputCount; i++)
        {
            listUserInputs.Add(ReadNumber());
        }

        foreach (var item in listUserInputs)
        {
            Console.Write($"{item} ");
        }

    }
}