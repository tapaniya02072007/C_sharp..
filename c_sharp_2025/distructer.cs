//distructer

using System;
class distructer
{
	static void Main()
	{
		xyz ob1=new xyz();
		xyz ob2=new xyz();
		Console.ReadLine();
		Console.WriteLine("happy");
	}
}
public class xyz
{
	public xyz()
	{
		Console.WriteLine("hello");
	}
	~xyz()
	{
		Console.WriteLine("hyy");
	}
}