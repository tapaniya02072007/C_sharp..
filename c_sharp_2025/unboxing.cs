using System;
class unboxing
{
	static void Main(string[] args)
	{
		int n; //value type datatype
		object a=10;  //reference type datatype
		n=(int)a;  //unboxing explicit
		Console.WriteLine(n);
		Console.WriteLine(a);
		Console.ReadLine();
	}
}