using System;

class hotal_menu_pro
{
    static void Main()
    {
        int choice, quantity;
        char ch = 'y';

        // Store total quantity of each item
        int dabeliQty = 0;
        int pavbhajiQty = 0;
        int manchurianQty = 0;
        int pizzaQty = 0;

        do
        {
            Console.WriteLine("------ RADHE HOTEL MENU ------");
            Console.WriteLine("1. Dabeli........Price:- 30");
            Console.WriteLine("2. Pavbhaji......Price:- 80");
            Console.WriteLine("3. Manchurian....Price:- 120");
            Console.WriteLine("4. Pizza ........Price:- 140");

            Console.Write("Select item: ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    dabeliQty += quantity;
                    break;

                case 2:
                    pavbhajiQty += quantity;
                    break;

                case 3:
                    manchurianQty += quantity;
                    break;

                case 4:
                    pizzaQty += quantity;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    continue;
            }

            Console.Write("Do you want to continue (y/n): ");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

        } while (ch == 'y' || ch == 'Y');

        // Final Bill
        Console.WriteLine("------ FINAL BILL ------");

        int finalTotal = 0;

        if (dabeliQty > 0)
        {
            int total = dabeliQty * 30;
            Console.WriteLine("Dabeli x " + dabeliQty + " = " + total);
            finalTotal += total;
        }

        if (pavbhajiQty > 0)
        {
            int total = pavbhajiQty * 80;
            Console.WriteLine("Pavbhaji x " + pavbhajiQty + " = " + total);
            finalTotal += total;
        }

        if (manchurianQty > 0)
        {
            int total = manchurianQty * 120;
            Console.WriteLine("Manchurian x " + manchurianQty + " = " + total);
            finalTotal += total;
        }

        if (pizzaQty > 0)
        {
            int total = pizzaQty * 140;
            Console.WriteLine("Pizza x " + pizzaQty + " = " + total);
            finalTotal += total;
        }

        Console.WriteLine("-----------------------");
        Console.WriteLine("Final Bill = " + finalTotal);
    }
}