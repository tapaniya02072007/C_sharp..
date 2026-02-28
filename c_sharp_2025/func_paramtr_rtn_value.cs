// function with parameter with return value

using System;
class demo
{
	static void Main()
	{
		abc a=new abc();
		int x=200;
		int r=a.m1(x); //calling of function
		Console.WriteLine("value of r:-"+r);
		Console.WriteLine("value of x:-"+x);
		Console.ReadLine();
	}
}
class abc
{
	public int m1(int a)
	{
		a+=100;
		return a;
	}
}
