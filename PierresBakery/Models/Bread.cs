using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class Bread
  {
    public string BreadLoaf { get; set; }
    public int BreadPrice { get; set; }
    private static List<Bread> _breadOrder = new List<Bread> { };

    public static void ClearOrder()
    {
      _breadOrder.Clear();
    }
  }
}
