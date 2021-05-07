using System.Collections.Generic;
using System;
using PierresBakery.Models;

namespace UserInterface
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Would you like to place an order? Yes/No");
      while (true)
      {
        string enterStore = Console.ReadLine().ToLower();
        if (enterStore == "yes")
        {
          Console.WriteLine("Great, what would you like to order? Bread, or Pastry?");
          string userOrderType = Console.ReadLine().ToLower();
          if (userOrderType == "bread")
          {
            Console.WriteLine("and how many loaves of bread would you like?");
            int userAmount = int.Parse(Console.ReadLine());
            Bread newBreadOrder = new Bread(userOrderType, userAmount);
          }
          else
          {
            Console.WriteLine("and how many pastries would you like?");
            int userAmount = int.Parse(Console.ReadLine());
            Pastry newBreadOrder = new Pastry(userOrderType, userAmount);
          }
        }
        else
        {
          Console.WriteLine("Okay, thanks for coming in. We hope to see you again!");
        }
        Console.WriteLine("Is there anything else you would like to add to your order? Yes/No");
        string addToOrder = Console.ReadLine().ToLower();
        if (addToOrder == "yes")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Okay, thanks for coming in. We hope to see you again!");
          List<Bread> breadTotal = Bread.ShowCheckout();
          foreach (Bread individualItem in breadTotal)
          {
            int amount = individualItem.BreadAmount;
          }
          List<Pastry> pastryTotal = Pastry.ShowCheckout();
          foreach (Pastry individualItem in pastryTotal)
          {
            int amount = individualItem.PastryAmount;
          }
          Console.WriteLine("This will have your total at some point");
          Environment.Exit(0);
        }
      }
    }
  }
}