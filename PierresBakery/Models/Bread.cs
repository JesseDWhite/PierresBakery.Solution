using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadLoaf { get; set; }
    public int BreadAmount { get; set; }
    public int breadPrice = 5;
    public int breadDiscounted = 1;
    public int totalBreadOrder = 0;
    private static List<Bread> _breadOrder = new List<Bread> { };
    public Bread(int breadLoaf)
    {
      int main = BreadLoaf = breadLoaf;
      int convert = main *= breadPrice;
      _breadOrder.Add(this);
      if (main == 2)
      {
        BreadAmount = convert;
        Console.WriteLine($"That was the first branch {convert}");
      }
      else
      {
        BreadAmount = convert;
        Console.WriteLine($"That was the second branch {convert}");
      }
    }
    public Bread(int breadLoaf, int breadAmount)
    : this(breadLoaf)
    {
      BreadAmount = breadAmount;
    }
    public static void ClearOrder()
    {
      _breadOrder.Clear();
    }
    public static List<Bread> ShowCheckout()
    {
      return _breadOrder;
    }
  }
}