using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearOrder();
    }
    [TestMethod]
    public void BreadConstructor_CreateAnEmptyListOfBread_Bread()
    {
      Bread newBreadOrder = new Bread("bread loaf");
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    [TestMethod]
    public void BreadItem_CreateListWithBreadItem_Bread()
    {
      string breadLoaf = "bread loaf";
      Bread newBreadOrder = new Bread(breadLoaf);
      string order = newBreadOrder.BreadLoaf;
      Assert.AreEqual(breadLoaf, order);
    }
    [TestMethod]
    public void BreadPrice_CreateListWithPrice_Bread()
    {
      int breadAmount = 5;
      Bread newBreadOrder = new Bread("bread loaf", 5);
      int order = newBreadOrder.BreadAmount;
      Assert.AreEqual(breadAmount, order);
    }
  }
}