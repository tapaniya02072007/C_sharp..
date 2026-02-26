// abstract_class

using System;
class demo
{
	static void Main()
	{
		//abc a=new abc();
		//we can't create object of abc because it is abstract
		
		xyz x=new xyz();
		x.fun(); //object of xyz and method of abc
		Console.ReadLine();
	}
}
public abstract class abc //it is always be parent class
{
	public void fun()
	{
		Console.WriteLine("hello abc");
	}
}
public class xyz:abc
{

}