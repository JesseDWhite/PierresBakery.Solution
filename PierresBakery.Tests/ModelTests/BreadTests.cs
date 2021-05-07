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
    public void BreadItem_CreateListWithBreadItem_String()
    {
      string breadLoaf = "bread loaf";
      Bread newBreadOrder = new Bread(breadLoaf);
      string order = newBreadOrder.BreadLoaf;
      Assert.AreEqual(breadLoaf, order);
    }
    [TestMethod]
    public void BreadPrice_CreateListWithPrice_Int()
    {
      int breadAmount = 5;
      Bread newBreadOrder = new Bread("bread loaf", 5);
      int order = newBreadOrder.BreadAmount;
      Assert.AreEqual(breadAmount, order);
    }
    [TestMethod]
    public void ShowCheckout_ReturnsEmptyOrderList_BreadList()
    {
      List<Bread> newBreadOrder = new List<Bread> { };
      List<Bread> checkout = Bread.ShowCheckout();
      CollectionAssert.AreEqual(newBreadOrder, checkout);
    }
    [TestMethod]
    public void ShowCheckout_ReturnsAllOrders_BreadList()
    {
      string newBreadOrder = "bread";
      int newBreadAmout = 5;
      Bread newOrder = new Bread(newBreadOrder, newBreadAmout);
      List<Bread> newBreadOrderList = new List<Bread> { newOrder };
      List<Bread> checkout = Bread.ShowCheckout();
      CollectionAssert.AreEqual(newBreadOrderList, checkout);
    }
    [TestMethod]
    public void BreadTotalPrice_AddNumberOfOrderToTotalPrice_BreadList()
    {
      int totalBreadOrder = 0;
      string newBreadOrder = "bread";
      int newBreadAmout = 2;
      Bread newOrder = new Bread(newBreadOrder, newBreadAmout);
      List<Bread> newBreadOrderList = new List<Bread> { newOrder };
      List<Bread> checkout = Bread.ShowCheckout();
      Assert.AreEqual(totalBreadOrder, checkout);
    }
  }
}