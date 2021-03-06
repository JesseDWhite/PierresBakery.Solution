using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryItem { get; set; }
    public int PastryPrice { get; set; }
    public int PastryTotal { get; set; }
    private static List<Pastry> _pastryOrder = new List<Pastry> { };
    public Pastry(int pastryItem)
    {
      PastryItem = pastryItem;
      PastryPrice = 2;
      _pastryOrder.Add(this);
    }
    public static void ClearOrder()
    {
      _pastryOrder.Clear();
    }
    public static List<Pastry> ShowCheckout()
    {
      return _pastryOrder;
    }
    public int GetDiscount()
    {
      int convert = PastryItem % 3;
      return (PastryItem / 3 * 5) + (convert * 2);
    }
  }
}