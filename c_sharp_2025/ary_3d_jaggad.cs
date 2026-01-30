using System;
class ary_3d_jaggad
{
	public static void Main()
	{
		 // Declare 3D jagged array
        int[][][] a = new int[2][][];

		a[0]=new int[3][];
		a[1]=new int[2][];
		
		a[0][0]=new int[2];
		a[0][1]=new int[3];
		a[0][2]=new int[5];
		
		a[1][0]=new int[2];
		a[1][1]=new int[3];
		
		        // Assign values
        int value = 1;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                for (int k = 0; k < a[i][j].Length; k++)
                {
                    a[i][j][k] = value++;
                }
            }
        }

        // Print values
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                for (int k = 0; k < a[i][j].Length; k++)
                {
                     Console.WriteLine("a[" + i + "][" + j + "][" + k + "] = " + a[i][j][k]);
                }
            }
        }
    }
}