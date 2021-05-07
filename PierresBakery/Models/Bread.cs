﻿using System;
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
  public class Pastry
  {
    public string PastryItem { get; set; }
    public int PastryPrice { get; set; }
    private static List<Pastry> _pastryOrder = new List<Pastry> { };
    public Pastry(string breadLoaf)
    {
      PastryItem = breadLoaf;
      _pastryOrder.Add(this);
    }
    public Pastry(string pastryItem, int pastryPrice)
    : this(pastryItem)
    {
      PastryPrice = pastryPrice;
    }
    public static void ClearOrder()
    {
      _pastryOrder.Clear();
    }

  }
}
