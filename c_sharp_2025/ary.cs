using System;
class ary
{
	static void Main()
	{
		int[]a=new int[3];
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