using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore.src
{
    public class FunctionsForChoice
    {
        public static int ChoicePerson(Customer name)
        {
            Console.WriteLine("Choose a person:\n1 - Nastya;\n2 - Dasha;\n3 - Stas;\nYour choice: ");
            int choice1 = Convert.ToInt32(Console.ReadLine());

            switch (choice1)
            {
                case 1:
                    Console.WriteLine($"Welcome, {name.CustomersList[0].CustomerName}! Choose books in your card.");
                    break;
                case 2:
                    Console.WriteLine($"Welcome, {name.CustomersList[1].CustomerName}! Choose books in your card.");
                    break;
                case 3:
                    Console.WriteLine($"Welcome, {name.CustomersList[2].CustomerName}! Choose books in your card.");
                    break;
                default:
                    Console.WriteLine($"Error! Please, try again!");
                    ChoicePerson(name);
                    break;
            }
            return choice1;
        }


        public static int ChoiceOfDelivery()
        {
            Console.WriteLine("\nChoose a delivery method:\n1 - NovaPoshta;\n2 - UkrPoshta;\n3 - Courier;\nYour choice: ");
            int choice3 = Convert.ToInt32(Console.ReadLine());

            switch (choice3)
            {
                case 1:
                    Console.WriteLine($"You have choose {deliveryCompaines.NovaPoshta}\n");
                    string? addressNovaPoshta;
                    try
                    {
                        Console.WriteLine($"Enter the address of Nova Poshta (Street and house number)");
                        addressNovaPoshta = Console.ReadLine();

                        if (addressNovaPoshta == "")
                        {
                            throw new Exception("You did not enter an address! Please try again.\n");
                        }
                        else
                        {
                            Console.WriteLine($"Address of your Nova Poshta: {addressNovaPoshta}.\n");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                        Console.WriteLine($"Enter the address of Nova Poshta (Street and house number)");
                        addressNovaPoshta = Console.ReadLine();
                        Console.WriteLine($"Address of your Nova Poshta: {addressNovaPoshta}.\n");
                    }
                    break;
                case 2:
                    Console.WriteLine($"You have choose {deliveryCompaines.UkrPoshta}\n");
                    string? addressUkrPoshta;
                    try
                    {
                        Console.WriteLine($"Enter the address of UkrPoshta (Street and house number)");
                        addressUkrPoshta = Console.ReadLine();
                        if (addressUkrPoshta == "")
                        {
                            throw new Exception("You did not enter an address! Please try again.\n");
                        }
                        else
                        {
                            Console.WriteLine($"Address of your Nova Poshta: {addressUkrPoshta}.\n");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                        Console.WriteLine($"Enter the address of UkrPoshta (Street and house number)");
                        addressUkrPoshta = Console.ReadLine();
                        Console.WriteLine($"Address of your Nova Poshta: {addressUkrPoshta}.\n");
                    }
                    break;
                case 3:
                    string? address;
                    try
                    {
                        Console.WriteLine($"You have choose Courier. Enter the shipping address: ");
                        address = Console.ReadLine();

                        if (address == "")
                        {
                            throw new Exception("You did not enter an address! Please try again.\n");
                        }
                        else
                        {
                            Console.WriteLine($"Your shipping address: {address}.\n");
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                        Console.WriteLine($"Enter the shipping address: ");
                        address = Console.ReadLine();
                        Console.WriteLine($"Your shipping address: {address}.\n");
                    }
                    break;
                default:
                    Console.WriteLine("Error! Choose an option from the ones offered!");
                    ChoiceOfDelivery();
                    break;
            }
            return choice3;
        }


        public static void PriceForOrder(ShoppingCart count)
        {
            Console.WriteLine("\nOur range of products: (If you don't want to buy the book, enter 0)\n1 - Harry Potter;\n2 - Tom Sawyer;\n3 - Lost;\n4 - Men who hate women;\n5 - The One;\n6 - Road;\n7 - Twelve Dancing Princesses;");
            int price = 0;

            for (int i = 0; i < count.addedProductsList.Count; i++)
            {
                Console.WriteLine($"\nPlease, enter the number of books {count.addedProductsList[i].Goods.Name}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "The number of products in the cart must be positive!");
                }

                price += count.addedProductsList[i].Price * number;
                Console.WriteLine($"The cost of your order: {price}");
            }
        }
    }
}