using System;
using System.Collections.Generic;

class dup_2d_arr
{
    static void Main()
    {
        Console.WriteLine("Enter the size of row:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the size of column:");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[rows, cols];

        Console.WriteLine("Enter " + (rows * cols) + " elements:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Array elements are:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (dict.ContainsKey(arr[i, j]))
                    dict[arr[i, j]]++;
                else
                    dict[arr[i, j]] = 1;
            }
        }

        Console.WriteLine("Duplicate elements and their counts:");
        foreach (var pair in dict)
        {
            if (pair.Value > 1)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
        }
    }
}