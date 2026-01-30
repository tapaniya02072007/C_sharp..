using System;

class ary_3d_jgd
{
    static void Main()
    {
        // Get dimension size
        Console.Write("Enter dimension size: ");
        int dim = int.Parse(Console.ReadLine());

        // Get row size
        Console.Write("Enter row size: ");
        int rows = int.Parse(Console.ReadLine());

        // Get column size
        Console.Write("Enter column size: ");
        int cols = int.Parse(Console.ReadLine());

        // Create 3D jagged array
        int[][][] arr = new int[dim][][];

        // Input values
        for (int d = 0; d < dim; d++)
        {
            arr[d] = new int[rows][];

             Console.WriteLine("\nEnter values for Dimension " + d + ":");

            for (int r = 0; r < rows; r++)
            {
                arr[d][r] = new int[cols];

                for (int c = 0; c < cols; c++)
                {
                    Console.Write("arr[" + d + "][" + r + "][" + c + "] = ");
                    arr[d][r][c] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Print values
        Console.WriteLine("\n3D Jagged Array Output:");
        for (int d = 0; d < dim; d++)
        {
            Console.WriteLine("Dimension " + d + ":"); 
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(arr[d][r][c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}