// hirarchical inheritance

using System;
class demo
{
	static void Main()
	{
		xyz x=new xyz();
		pqr p=new pqr();
		p.method();
		x.print();
		Console.ReadLine();
	}
}
public class abc
{
	protected void disp()
	{
		Console.WriteLine("hello parent");
	}
}
public class xyz:abc
{
	public void print()
	{
		Console.WriteLine("hello xyz child");
		disp();
		Console.WriteLine("back to xyz child");
	}
}
public class pqr:abc 
{
	public void method()
	{
		Console.WriteLine("hello pqr child");
		disp();
		Console.WriteLine("back to pqr child");
	}
}
