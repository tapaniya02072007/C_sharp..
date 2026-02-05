// switch case
using System;

class hotal_menu
{
    static void Main()
    {
        int choice;
        char again;

        do
        {
            Console.WriteLine("------ WELCOME TO HOTEL ------");
            Console.WriteLine("1. Tea        - Rs. 10");
            Console.WriteLine("2. Coffee     - Rs. 20");
            Console.WriteLine("3. Sandwich   - Rs. 50");
            Console.WriteLine("4. Pizza      - Rs. 120");
            Console.WriteLine("5. Burger     - Rs. 80");
            Console.WriteLine("------------------------------");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Tea. :Rs. 10");
                      break;

                case 2:
                    Console.WriteLine("Coffee. :Rs. 20");
                    break;

                case 3:
                    Console.WriteLine("Sandwich. :Rs. 50");
                    break;

                case 4:
                    Console.WriteLine("Pizza. :Rs. 120");
                    break;

                case 5:
                    Console.WriteLine("Burger. :Rs. 80");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.Write("\nDo you want to order again? (y/n): ");
            again = Convert.ToChar(Console.ReadLine());

            Console.Clear();

        }while (again == 'y' || again == 'Y');

        Console.WriteLine("Thank you");
    }
}