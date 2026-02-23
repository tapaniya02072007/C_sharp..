// multilevel inheritance

using System;
class demo
{
	static void Main()
	{
		pqr p=new pqr();
		p.method();
		
		Console.ReadLine();
	}
}
public class abc //super parent class
{
	protected void disp()
	{
		Console.WriteLine("disp");
	}
}
public class xyz:abc //child class
{}
public class pqr:xyz //sub child class
{
	public void method()
	{
		Console.WriteLine("hello sub child");
		disp();
		Console.WriteLine("back to sub child");
	}
}