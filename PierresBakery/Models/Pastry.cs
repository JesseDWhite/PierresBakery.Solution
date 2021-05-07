using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public string PastryItem { get; set; }
    public int PastryAmount { get; set; }
    private static List<Pastry> _pastryOrder = new List<Pastry> { };
    public Pastry(string pastryItem)
    {
      PastryItem = pastryItem;
      _pastryOrder.Add(this);
    }
    public Pastry(string pastryItem, int pastryAmount)
    : this(pastryItem)
    {
      PastryAmount = pastryAmount;
    }
    public static void ClearOrder()
    {
      _pastryOrder.Clear();
    }

  }
}