using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryItem { get; set; }
    public int PastryAmount { get; set; }
    public int pastryPrice = 2;
    public int pastryDiscounted = 5;
    public int totalPastryOrder = 0;
    private static List<Pastry> _pastryOrder = new List<Pastry> { };
    public Pastry(int pastryItem)
    {
      int main = PastryItem = pastryItem;
      int convert = main *= pastryPrice;
      _pastryOrder.Add(this);
      PastryAmount = convert;
    }
    public Pastry(int pastryItem, int pastryAmount)
    : this(pastryItem)
    {
      PastryAmount = pastryAmount;
    }
    public static void ClearOrder()
    {
      _pastryOrder.Clear();
    }
    public static List<Pastry> ShowCheckout()
    {
      return _pastryOrder;
    }
  }
}