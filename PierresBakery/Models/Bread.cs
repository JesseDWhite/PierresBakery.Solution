using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadLoaf { get; set; }
    public int BreadPrice { get; set; }
    public int BreadTotal { get; set; }
    private static List<Bread> _breadOrder = new List<Bread> { };
    public Bread(int breadLoaf)
    {
      BreadLoaf = breadLoaf;
      BreadPrice = 5;
      _breadOrder.Add(this);
    }
    public static void ClearOrder()
    {
      _breadOrder.Clear();
    }
    public static List<Bread> ShowCheckout()
    {
      return _breadOrder;
    }
    public int GetPrice()
    {
      BreadTotal = BreadLoaf *= BreadPrice;
      return BreadTotal;
    }
    public int GetDiscount()
    {
      if (BreadLoaf > 1)
      {
        return (BreadLoaf * 5) - (BreadLoaf / 3 * BreadPrice);
      }
      else
      {
        return BreadLoaf * BreadPrice;
      }
    }
  }
}

