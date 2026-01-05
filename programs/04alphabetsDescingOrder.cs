namespace Problems;

public class AlphabetsDescendingOrder
{
    public static void Run()
    {
        List<char> alphabets = new List<char>{
                                                'A','B','C','D','E','F','G','H','I','J',
                                                'K','L','M','N','O','P','Q','R','S','T',
                                                'U','V','W','X','Y','Z'
                                            };


        // for(int i = alphabets.Count - 1; i >= 0; i--)
        // {
        //     Console.WriteLine($"{i + 1} - {alphabets[i]}");
        // }

        for (int c = 'A'; c <= 'Z'; c++)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();
        for (char c = 'A'; c <= 'Z'; c++)
        {
            Console.Write($"{c} ");
        }


        Console.WriteLine();
        int unicodeOfAMinus = 'A' - 1;
        Console.Write("Please enter the number between 1 to 26: ");
        int inputNum = Convert.ToInt32(Console.ReadLine()) + unicodeOfAMinus;

        Console.WriteLine($"user input number is {(char)inputNum}");
    }
}