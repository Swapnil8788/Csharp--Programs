namespace Problems;

public class EvenIndexNumbers
{
    public static void Run()
    {
        // List<int> listNumbers = new List<int>() { 2, 3, 4, 4, 6, 2, 1, 6, 3 };
        // for (int i = 0; i < listNumbers.Count; i++)
        // {
        //     if(i % 2 == 0)
        //     {
        //         Console.Write($"{listNumbers[i]}");
        //     }
        // }

        int[] arrayValues = new int[8]{2,3,4,5,3,2,4,5};

        Array.Sort(arrayValues);

        foreach (var item in arrayValues)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
        Array.Reverse(arrayValues);
        foreach (var item in arrayValues)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        Array.Clear(arrayValues, 0, arrayValues.Length - 1);
        foreach (var item in arrayValues)
        {
            Console.Write($"{item} ");
        }
    }
}