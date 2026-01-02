using System;                                      //type casting
class boxing                                       // 1. boxing
{                                                  // 2. unboxing
	static void Main()
	{
		int n=100;
		object a=n; //boxing
		Console.WriteLine(n);
		Console.WriteLine(a);
	}
}