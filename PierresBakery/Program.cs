using System.Collections.Generic;
using System;
using PierresBakery.Models;

namespace UserInterface
{
  public class Program
  {
    static void Main()
    {
      int customerBreadCart = 0;
      int customerPastryCart = 0;
      Console.WriteLine("Welcome to Pierre's Bakery! Would you like to place an order? Yes/No");
      string enterStore = Console.ReadLine().ToLower();
      while (enterStore == "yes")
      {
        if (enterStore == "yes")
        {
          Console.WriteLine("Great, what would you like to order? Bread, or Pastry?");
          string userOrderType = Console.ReadLine().ToLower();
          if (userOrderType == "bread")
          {
            Console.WriteLine("Bread is buy 2 get 1 free. How many loaves of bread would you like?");
            int userAmount = int.Parse(Console.ReadLine());
            Bread newBreadOrder = new Bread(userAmount);
            customerBreadCart += newBreadOrder.GetDiscount();
            newBreadOrder.BreadTotal = customerBreadCart;
          }
          else if (userOrderType == "pastry")
          {
            Console.WriteLine("Pastries are buy 3 get 1 for $1.00. How many pastries would you like?");
            int userAmount = int.Parse(Console.ReadLine());
            Pastry newPastryOrder = new Pastry(userAmount);
            customerPastryCart += newPastryOrder.GetDiscount();
            newPastryOrder.PastryTotal = customerPastryCart;
          }
          else
          {
            Console.WriteLine("Okay, we're sorry we do not have what you are looking for.");
            Environment.Exit(0);
          }
        }
        else
        {
          Console.WriteLine("Chiabatta stay away from me. I don't want naan of that!");
          Environment.Exit(0);
        }
        Console.WriteLine("Is there anything else you would like to add to your order? Yes/No");
        string addToOrder = Console.ReadLine().ToLower();
        if (addToOrder == "yes")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Okay, thanks for coming in. We really kneeded the dough!");
          int checkoutBreadTotal = 0;
          int checkoutPastryTotal = 0;
          List<Bread> newBreadOrder = Bread.ShowCheckout();
          foreach (Bread individualLoaf in newBreadOrder)
          {
            int amount = individualLoaf.BreadTotal;
            checkoutBreadTotal += amount;
            Console.WriteLine($"Your total amount for your order of bread is: ${checkoutBreadTotal}.00");
          }
          List<Pastry> newPastryOrder = Pastry.ShowCheckout();
          foreach (Pastry individualPastry in newPastryOrder)
          {
            int amount = individualPastry.PastryTotal;
            checkoutPastryTotal += amount;
            Console.WriteLine($"Your total amount for your order of pastries is: ${checkoutPastryTotal}.00");
          }
          Console.WriteLine($"You owe us: ${checkoutBreadTotal += checkoutPastryTotal}.00 in total. No we do not accept cryptocurrency.");
          Environment.Exit(0);
        }
      }
    }
  }
}