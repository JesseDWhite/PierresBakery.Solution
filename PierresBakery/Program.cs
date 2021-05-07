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
      Console.WriteLine(enterStore);

    }
  }
}