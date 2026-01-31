using System;
class looping
{
	static void Main()
	{
		//foreach loop
		int[]a=new int[5]{2,4,6,8,10};
		foreach(int v in a)
		{
			Console.WriteLine(v);
		}
		Console.WriteLine();
		
		//for loop
		for(int i=0; i<a.Length; i++)
		{
			Console.WriteLine(a[i]);
		}
		Console.WriteLine();
		
		//while loop
		int j=0;
		while(j<a.Length)
		{
			Console.WriteLine(a[j]);
			j++;
		}
		Console.WriteLine();
		
		//do while looping
		int t=0;
		do
		{
			Console.WriteLine(a[t]);
			t++;
		}
		while(t<a.Length);
		Console.WriteLine();
	}
}