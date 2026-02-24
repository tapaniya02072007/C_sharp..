// method overriding

using System;
class demo
{
	static void Main()
	{
		pqr p=new pqr();
		p.method(10);
		p.method(20);
		Console.WriteLine();
	}
}
public class abc
{
	public virtual void method(int a)
	{
		Console.WriteLine("happy");
	}
}
public class pqr:abc
{
	public override void method(int a)
	{
		Console.WriteLine("hello");
	}
}