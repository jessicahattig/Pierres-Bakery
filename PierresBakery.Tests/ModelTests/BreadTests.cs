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
      Bread bread = new Bread { Quantity = 2 };

      //Act
      double cost = bread.CalculateCost();

      //Assert
      Assert.AreEqual(10.0, cost, 0.001);
    }

    [TestMethod]
    public void CalculateCost_Buy2Get1Free()
    {
      //Arrange
      Bread bread = new Bread { Quantity = 3 };

      //Act
      double cost = bread.CalculateCost();

      //Assert
      Assert.AreEqual(10.0, cost, 0.001);
    }

    [TestMethod]
    public void CalculateCost_Buy4loaves()
    {
      //Arrange
      Bread bread = new Bread { Quantity = 4 };

      //Act
      double cost = bread.CalculateCost();

      //Assert
      Assert.AreEqual(15.0, cost, 0.001);
    }
  }
}