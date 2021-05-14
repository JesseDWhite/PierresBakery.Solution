using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearOrder();
    }
    [TestMethod]
    public void PastryConstructor_CreateAnEmptyListOfPastry_Pastry()
    {
      Pastry newPastryOrder = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }
    [TestMethod]
    public void PastryItem_CreateListWithPastryItem_String()
    {
      int PastryLoaf = 1;
      Pastry newPastryOrder = new Pastry(PastryLoaf);
      int order = newPastryOrder.PastryItem;
      Assert.AreEqual(PastryLoaf, order);
    }
    [TestMethod]
    public void PastryPrice_CreateListWithPrice_Int()
    {
      int PastryAmount = 25;
      Pastry newPastryOrder = new Pastry(5);
      int order = newPastryOrder.GetPrice();
      Assert.AreEqual(PastryAmount, order);
    }
    [TestMethod]
    public void ShowCheckout_ReturnsEmptyOrderList_PastryList()
    {
      List<Pastry> newPastryOrder = new List<Pastry> { };
      List<Pastry> checkout = Pastry.ShowCheckout();
      CollectionAssert.AreEqual(newPastryOrder, checkout);
    }
    [TestMethod]
    public void ShowCheckout_ReturnsAllOrders_PastryList()
    {
      int newPastryOrder = 1;
      Pastry newOrder = new Pastry(newPastryOrder);
      List<Pastry> newPastryOrderList = new List<Pastry> { newOrder };
      List<Pastry> checkout = Pastry.ShowCheckout();
      CollectionAssert.AreEqual(newPastryOrderList, checkout);
    }
    [TestMethod]
    public void ApplyDiscount_ReturnDiscountedRate_PastryList()
    {
      int discountedPastry = 10;
      Pastry newPastryOrder = new Pastry(3);
      int order = newPastryOrder.GetDiscount();
      Assert.AreEqual(discountedPastry, order);
    }
    [TestMethod]
    public void ApplyLargerDiscount_ReturnDiscountedRateAbove3Items_PastryList()
    {
      int discountedPastry = 20;
      Pastry newPastryOrder = new Pastry(6);
      int order = newPastryOrder.GetDiscount();
      Assert.AreEqual(discountedPastry, order);
    }
    [TestMethod]
    public void ApplyLargerDiscount_ReturnDiscountedRateOfOddNumberNotDivisibleByThree_PastryList()
    {
      int discountedPastry = 25;
      Pastry newPastryOrder = new Pastry(7);
      int order = newPastryOrder.GetDiscount();
      Assert.AreEqual(discountedPastry, order);
    }

  }
}