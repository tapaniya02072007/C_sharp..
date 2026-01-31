//continue Statement
using System;
class while_loop
{
	static void Main()
	{
		int i=0;
		while(i<10)
		{
			i++;
			if(i==3)
			continue;
		}
		Console.WriteLine("loop stopped at i:"+i);
	}
}