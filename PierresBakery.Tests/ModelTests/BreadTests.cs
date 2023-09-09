using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests : IDisposable
  {
    public void Dispose()
    {
      //ClearAll();
    }

    [TestMethod]
    public void CalculateCost_NoDiscount()
    {
      //Arrange
      Pastry pastry = new Pastry { Quantity = 2 };

      //Act
      double cost = pastry.CalculateCost();

      //Assert
      Assert.AreEqual(10.0, cost, 0.001);
    }
  }
}