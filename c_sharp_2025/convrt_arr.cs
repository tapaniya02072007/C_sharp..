using System;
class convrt_arr
{
	static void Main()
	{
		Console.WriteLine("enter size for array");
		
		int size=Convert.ToInt32(Console.ReadLine());
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