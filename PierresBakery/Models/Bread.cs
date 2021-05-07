﻿using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public string BreadLoaf { get; set; }
    public int BreadAmount { get; set; }
    public int breadPrice = 5;
    public int breadDiscounted = 0;
    public int totalBreadOrder = 0;
    private static List<Bread> _breadOrder = new List<Bread> { };
    public Bread(string breadLoaf)
    {
      BreadLoaf = breadLoaf;
      _breadOrder.Add(this);
    }
    public Bread(string breadLoaf, int breadAmount)
    : this(breadLoaf)
    {
      BreadAmount = breadAmount *= breadPrice;
      int total = BreadAmount += totalBreadOrder;
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