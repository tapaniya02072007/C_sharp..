// inheritance

using System;
class inherit
{
	static void Main()
	{
		xyz ob1=new xyz();
		xyz ob2=new xyz();
		ob2.a=463; //assign value to other class
		ob1.a=29;
		ob1.show();
		ob2.show();
		Console.ReadLine();
	}
}
public class xyz
{
	public int a;
	public void show()
	{
		Console.WriteLine("this is show:-"+a);
		// print value inside public method
	}
}