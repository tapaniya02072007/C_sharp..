// interface

using System;
class demo
{
	static void Main()
	{
		cls1 c1=new cls1();
		c1.m1();
		Console.ReadLine();
	}
}
interface intr1
{
	void m1(); //dec
	//it is by default public method
}
class cls1:intr1
{
	public void m1() //default intr1's method
	{
		Console.WriteLine("hello m1");
	}
}