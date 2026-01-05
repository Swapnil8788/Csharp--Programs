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


        for(int i = alphabets.Count - 1; i >= 0; i--)
        {
            Console.WriteLine($"{i + 1} - {alphabets[i]}");
        }
    }
}