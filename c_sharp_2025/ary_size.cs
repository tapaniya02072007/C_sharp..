using System;
class ary_size
{
	static void Main()
	{
		int size=20;
		int []a=new int[size];
		a[0]=30;
		a[1]=60;
		a[2]=90;
		
		Console.WriteLine("size of array:-"+a.Length);
		for(int i=0; i<a.Length; i++)
		{
			Console.WriteLine(a[i]);
		}
		Console.ReadLine();
	}
}