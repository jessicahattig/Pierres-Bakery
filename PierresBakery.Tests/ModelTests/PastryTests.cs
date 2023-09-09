using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      //ClearAll();
    }

    [TestMethod]
    public void CalculateCost_NoDiscount()
    {
      //Arrange
      Pastry pastry = new Pastry { Quantity = 1 };

      //Act
      double cost = pastry.CalculateCost();

      //Assert
      Assert.AreEqual(2.0, cost, 0.001);
    }
    
    [TestMethod]
    public void CalculateCost_Discount_Quantity4()
    {
      //Arrange
      Pastry pastry = new Pastry { Quantity = 4};

      //Act
      double cost = pastry.CalculateCost();

      //Assert
      Assert.AreEqual(5.0, cost, 0.001);
    }
  }
}