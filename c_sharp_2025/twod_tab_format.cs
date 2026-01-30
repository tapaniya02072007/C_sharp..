using System;
class twod_tab_format
{
	static void Main()
	{
		Console.WriteLine("enter your row size:-");
			int r=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter your column size:-");
			int c=Convert.ToInt32(Console.ReadLine());
	
		int[,]ary2d=new int [r,c];
		Console.WriteLine("enter your element:-");
		for(int i=0; i<ary2d.GetLength(0); i++)
		{
			for(int j=0; j<ary2d.GetLength(1); j++)
			{
				ary2d[i, j] = Convert.ToInt32(Console.ReadLine());
			}
		}
	}
}