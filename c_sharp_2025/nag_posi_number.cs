using System;

class nag_posi_number
{
    public static void Main()
    {
        int n;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            Console.WriteLine("Number is Positive");
        }
        else if (n < 0)
        {
            Console.WriteLine("Number is Negative");
        }
        else
        {
            Console.WriteLine("Number is Zero");
        }
    }
}