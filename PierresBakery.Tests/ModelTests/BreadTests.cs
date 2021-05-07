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
  }
}