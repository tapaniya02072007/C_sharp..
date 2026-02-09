using System;

class hotal_menu_pro
{
    static void Main()
    {
        int choice, quantity;
        int price = 0;
        string itemName = "";
        char ch = 'y';

        do
        {
            Console.WriteLine("------ RADHE HOTEL MENU ------");
            Console.WriteLine("1. Dabeli........Price:- 30");
            Console.WriteLine("2. Pavbhaji......Price:- 80");
            Console.WriteLine("3. Manchurian....Price:- 120");
            Console.WriteLine("4. Pizza ........Price:- 140");

            Console.Write("Select item: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    itemName = "Dabeli";
                    price = 30;
                    break;

                case 2:
                    itemName = "Pavbhaji";
                    price = 80;
                    break;

                case 3:
                    itemName = "Manchurian";
                    price = 120;
                    break;

                case 4:
                    itemName = "Pizza";
                    price = 140;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    continue;
            }

            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            int total = price * quantity;

            Console.WriteLine("You selected: " + itemName);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total: " + total);

            Console.Write("Do you want to continue (y/n): ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'n' || ch == 'N')
            {
                Console.WriteLine("Final Bill Amount: " + total);
                break;
            }

            Console.WriteLine();

        } while (ch == 'y' || ch == 'Y');
    }
}