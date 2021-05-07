using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public string BreadLoaf { get; set; }
    public int BreadPrice { get; set; }
    private static List<Bread> _breadOrder = new List<Bread> { };
    public Bread(string breadLoaf)
    {
      BreadLoaf = breadLoaf;
      _breadOrder.Add(this);
    }
    public Bread(string breadLoaf, int breadPrice)
    : this(breadLoaf)
    {
      BreadPrice = breadPrice;
    }
    public static void ClearOrder()
    {
      _breadOrder.Clear();
    }
  }
}