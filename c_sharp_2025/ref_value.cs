//ref value

using System;
class demo
{
	static void Main()
	{
		abc a=new abc();
		int x=200;
		Console.WriteLine("befour:-"+x);
		a.m1(ref x); //&x
		Console.WriteLine("after:-"+x);
		Console.ReadLine();
	}
}
class abc
{
	public void m1(ref int a) //*a=&^x
	{
		Console.WriteLine("befour a:-"+a);
		a+=100;
		Console.WriteLine("after a:-"+a);
	}
}


	