using System;
class demo
{
	static void Main()
	{
		abc obj=new abc();
		obj[0]=10; //calling of indexer to store element
		obj[1]=49;
		obj[2]=82;
		
		//calling of indexer to print element
		Console.WriteLine("value of property:-"+obj[0]);
		Console.WriteLine("value of property:-"+obj[1]);
		Console.WriteLine("value of property:-"+obj[2]);
	}

}
class abc
{
	int []a=new int[3]; //indexer
	public int this[int i] //indexer
	{
		set
		{
			a[i]=value;
		}
		get
		{
			return a[i];
		}
	}
}