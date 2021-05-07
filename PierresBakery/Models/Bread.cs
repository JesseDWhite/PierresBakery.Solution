using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadLoaf { get; set; }
    public int BreadAmount { get; set; }
    public int breadPrice = 5;
    public int breadDiscounted = 0;
    public int totalBreadOrder = 0;
    private static List<Bread> _breadOrder = new List<Bread> { };
    public Bread(int breadLoaf)
    {
      BreadLoaf = breadLoaf;
      _breadOrder.Add(this);
    }
    public Bread(int breadLoaf, int breadAmount)
    : this(breadLoaf)
    {
      if (breadAmount % 2 == 0)
      {
        int total = BreadAmount = breadAmount *= breadPrice;
        int convert = total / 2;
        int addToTotal = convert += totalBreadOrder;
        BreadAmount = convert;
      }
      else
      {
        int getOneFree = breadAmount -= 1;
        int total = BreadAmount = breadAmount *= breadPrice;
        breadAmount = getOneFree;
      }
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