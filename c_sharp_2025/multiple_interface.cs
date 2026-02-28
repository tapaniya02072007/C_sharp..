// multiple_interface

using System;
class demo
{
	static void Main()
	{
		cls1 c1=new cls1();
		c1.m1();
		c1.m2();
		Console.ReadLine();
	}	
}
interface intr1
{
	void m1(); //dec
	//it is by default public method
}
interface intr2
{
	void m2();
}
class cls1:intr1,intr2 //multiple interface apply in a class
{
	public void m1() //define intr1's method
	{
		Console.WriteLine("hello m1");
	}
	public void m2() //define intr2's method
	{
		Console.WriteLine("happy m2");
	}
}