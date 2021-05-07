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
      int total = BreadLoaf = breadLoaf;
      if (total % 2 == 0)
      {
        total += breadDiscounted;
        _breadOrder.Add(this);
        Console.WriteLine($"That was the first branch {total}");
      }
      else
      {
        _breadOrder.Add(this);
        Console.WriteLine("That was the second branch");
      }
    }
    public Bread(int breadLoaf, int breadAmount)
    : this(breadLoaf)
    {
      BreadAmount = breadAmount *= breadPrice;
      int total = BreadAmount += totalBreadOrder;
    }
    // if (breadAmount % 2 == 0)
    // {
    //   int total = BreadAmount = breadAmount *= breadPrice;
    //   int convert = total / 2;
    //   int addToTotal = convert += totalBreadOrder;
    //   BreadAmount = convert;
    // }
    // else
    // {
    //   int getOneFree = breadAmount -= 1;
    //   int total = BreadAmount = breadAmount *= breadPrice;
    //   breadAmount = getOneFree;
    // }

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