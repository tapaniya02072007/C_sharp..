using System;
class multi_d_ary
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
		
		Console.WriteLine("with msg" +a[0,0]+""+a[0,1]);
	}
}