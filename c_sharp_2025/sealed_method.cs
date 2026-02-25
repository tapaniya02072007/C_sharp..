// sealed method

using System;
class sealed_
{
	static void Main()
	{
		pqr p=new pqr();
		xyz x=new xyz();
		p.method();  //sealed method 
		x.method1();
		Console.ReadLine();
	}
}
public class abc
{
	public virtual void method()
	{
		Console.WriteLine("hyy abc");
	}
}
public class pqr:abc
{	
	public sealed override void method()
	// we cannot overridethis method to it is child class of because it is sealed method
	{
		Console.WriteLine("hello pqr");
	}
}
public class xyz:pqr
{
	public void method1()
	{
		Console.WriteLine("happy xyz");
	}
}
