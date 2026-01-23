using System;
class ary_2d_tab_formate
{
	public static void Main()
	{
		Console.WriteLine("enter your row size:-");
			int r=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter your column size:-");
			int c=Convert.ToInt32(Console.ReadLine());
			
		Console.WriteLine("enter your element:-");
			int[,] ary2d=new int[r,c];
		
		 // Input values
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                ary2d[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Print in tabular format
        for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < c; j++)
			{
				Console.Write("[" + i + "," + j + "]=" + ary2d[i, j] + "\t");
			}
			Console.WriteLine();
		}
		//Console.ReadLine();
	}
}