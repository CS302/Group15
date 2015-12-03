using System;

public class Test
{
    public static void Main()
    {
        int[] arr = { 6, 9, 3, 4, 1, 8, 7 };
        int min = 100;
        int minPos = 100;
        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
                minPos = i;
            }
        }
        Console.WriteLine("Minimum is " + min + " at position " + minPos);
    }
}


