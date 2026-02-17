//copy constructer

using System;
class copy_constructr
{
	static void Main()
	{
		xyz obj1=new xyz(17);  //17 is a int type
		//calling perameter constructer
		xyz obj2=new xyz(obj1);  //obj1 is xyz type
		// calling of copy constructer
		
		obj1.show();
		obj2.show();
		Console.ReadLine();
	}
}
public class xyz
{
	int x; // feild data member local within entire class
	public xyz(int a)  //perameter local within comnstructer
	{
		x=a;
		Console.WriteLine("hello perameter");
	}
	public xyz(xyz temp) //copy constructer temp=obj1
	{
		Console.WriteLine("before"+x);
		x=temp.x;
		Console.WriteLine("after copy"+x);
	}
	public void show()
	{
		Console.WriteLine("value:"+x);
	}
}