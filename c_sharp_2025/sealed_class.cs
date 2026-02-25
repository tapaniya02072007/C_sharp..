//sealed class

using System;
class sealed_
{
	static void Main()
	{
		pqr p=new pqr();  //sealed class
		xyz x=new xyz();
		p.method1();
		p.method2();
		x.method3();
		x.method1();
	}
}
public class abc
{
	public void method1()
	{
		Console.WriteLine("hyy abc");
	}
}
public sealed class pqr:abc  //we cannot create child class of pqr because it is sealed
{
	public void method2()
	{
		Console.WriteLine("hello pqr");
	}
}
public class xyz:abc
{
	public void method3()
	{
		Console.WriteLine("happy xyz");
	}
}