//simple copy constructer

using System;
class smpl_cpy_cnstrcter
{
    static void Main()
    {
        xyz obj1 = new xyz(83); //83 is int type
        xyz obj2 = new xyz(obj1); //obj1 is xyz type
        //obj1.show();
        //obj2.show();
        Console.ReadLine();
    }
}
public class xyz
{
    int value;   // data member

    public xyz(int a)
    {
        value = a;
        Console.WriteLine("hello perameter");
    }

    public xyz(xyz temp) //copy constructer
    {
        value = temp.value;
        Console.WriteLine("hello copy");
    }

    public void show()
    {
        Console.WriteLine("value: " + value);
    }
}