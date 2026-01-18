using System;
class multi_d_ary_length
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
		
		for(int i=0; i<2; i++)
		{
			for(int j=0; j<3; j++)
			{
				Console.WriteLine(a[i,j]);
			}
		}
		Console.ReadLine();
	}
}