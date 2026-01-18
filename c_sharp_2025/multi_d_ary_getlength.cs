using System;
class multi_d_ary_getlength
{
	static void Main()
	{
		int [,] a=new int [2,3];
		
		a[0,0]=6;
		a[0,1]=3;
		a[0,2]=4;
		a[1,0]=5;
		a[1,1]=7;
		a[1,2]=8;
		
		Console.WriteLine("total number of element:-" +a.Length);
		Console.WriteLine("total number of row size:-" +a.GetLength(0));
		Console.WriteLine("total number of column size:-" +a.GetLength(1));
		
		for(int i=0; i<a.GetLength(0); i++)
		{
			for(int j=0; j<a.GetLength(1); j++)
			{
				Console.WriteLine(a[i,j]);
			}
		}
		Console.ReadLine();
	}
}