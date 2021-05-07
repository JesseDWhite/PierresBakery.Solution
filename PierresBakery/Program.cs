using System.Collections.Generic;
using System;

namespace UserInterface
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Would you like to place an order? Yes/No");
      string enterStore = Console.ReadLine().ToLower();
      if (enterStore == "yes")
      {
        Console.WriteLine("Great, what would you like to order?");
        string userOrder = Console.ReadLine();


      }
      else
      {
        Console.WriteLine("Okay, thanks for coming in. We hope to see you again!");
      }

    }
  }
}