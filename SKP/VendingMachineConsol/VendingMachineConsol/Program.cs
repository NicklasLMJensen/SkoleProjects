using System;
using System.Collections.Generic;
using VendingMachineConsol;
using static VendingMachineConsol.Product;
using static VendingMachineConsol.soda;
using static VendingMachineConsol.snack;
using static VendingMachineConsol.coffee;

//string[] sodas = { "Coke", "Pepsi", "Fanta", "Sprite", "Coke Zero" };
//decimal[] prices = { 15.00m, 12.50m, 13.75m, 11.00m, 14.00m };

List<Product> products = new List<Product>
{
    new Soda("Coke", 15.00m, 35),
    new Soda("Pepsi", 12.50m, 40),
    new Snack("Chips", 10.00m, 150),
    new Snack("Candy Bar", 8.50m, 50),
    new Coffee("Espresso", 20.00m, "Strong"),
    new Coffee("Latte", 18.00m, "Mild")
};


Console.WriteLine("Welcome to the vending machine!");


while (true)
{

    Console.WriteLine("\nAvailable products");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Describe()}");
    }



    Console.WriteLine("\nPlease select a product by entering the number (or type 0 to exit)");

    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        if (choice == 0)
        {
            Console.WriteLine("Thanks for using our Vending Machine");
            break;
        }
        else if (choice > 0 && choice <= products.Count)
        {
            Product SelectedProdtuct = products[choice - 1];
            Console.WriteLine($"You selected: {SelectedProdtuct.Describe()}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

    }

}






//while (true)
//{
//    //Display Menu
//    Console.WriteLine("\nAvailable sodas: ");
//    for (int i = 0; i < sodas.Length; i++)
//    {
//        Console.WriteLine($"{i + 1}. {sodas[i]} - {prices[i]} ");
//    }

    //    Console.WriteLine("\nPlease select a soda by entering the number (or type 0 to exit)");

    //    if (int.TryParse(Console.ReadLine(), out int choice))
    //    {
    //        if (choice == 0)
    //        {
    //            Console.WriteLine("Thanks for using our Vending Machine");
    //            break;
    //        }
    //        else if (choice > 0 && choice <= sodas.Length)
    //        {
    //            Console.WriteLine($"You chose {sodas[choice - 1]} which cost {prices[choice - 1]}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid selection. Please try again.");
    //        }

    //    }
    //    else
    //    {
    //        Console.WriteLine("Invalid input. Please enter a number");
    //    }
