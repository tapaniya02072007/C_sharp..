//static constructer

using System;
class static_constru
{
	static void Main()
	{
		xyz ob1=new xyz();
		xyz ob2=new xyz();
		Console.ReadLine();
	}
}
public class xyz
{
	public xyz()
	{
		Console.WriteLine("hello");
	}
	static xyz()
	{
		Console.WriteLine("happy");
	}
}