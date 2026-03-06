using System;
class indexer_size
{
	static void Main()
	{
		abc obj=new abc();
		obj [0]=10; //calling of indexer to store element
		obj [1]=54;
		obj [2]=-45;
		//calling of indexer to print element
		
		for(int p=0; p<obj.s; p++)
		{
			Console.WriteLine("value of property:-"+obj[p]);
		}
		Console.ReadLine();
	}
}
class abc
{
	public int s;
	int []a=new int[10]; //indexer
	public abc() //to get size of abc
	{
			s=a.Length;
	}
	public int this[int i]
	{
		set
		{
			a[i]=value;
		}
		get
		{
			if(i>=0 && i<a.Length)
				return a[i];
			else
				return 0;
		}
	}
}