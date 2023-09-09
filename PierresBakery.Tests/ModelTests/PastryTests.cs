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
    public void CalculateCost_Buy3Get1Free()
    {
      //Arrange
      Pastry pastry = new Pastry { Quantity = 4};

      //Act
      double cost = pastry.CalculateCost();

      //Assert
      Assert.AreEqual(6.0, cost, 0.001);
    }

    [TestMethod]
    public void CalculateCost_Buy5Pastries()
    {
      //Arrange
      Pastry pastry = new Pastry { Quantity = 5};

      //Act
      double cost = pastry.CalculateCost();

      //Assert
      Assert.AreEqual(8.0, cost, 0.001);
    }

    [TestMethod]
    public void CalculateCost_Buy6Pastries()
    {
      //Arrange
      Pastry pastry = new Pastry { Quantity = 6};

      //Act
      double cost = pastry.CalculateCost();

      //Assert
      Assert.AreEqual(10.0, cost, 0.001);
    }

  [TestMethod]
    public void CalculateCost_Buy7Pastries()
    {
      //Arrange
      Pastry pastry = new Pastry { Quantity = 7};

      //Act
      double cost = pastry.CalculateCost();

      //Assert
      Assert.AreEqual(12.0, cost, 0.001);
    }

  [TestMethod]
    public void CalculateCost_Buy8Pastries()
    {
      //Arrange
      Pastry pastry = new Pastry { Quantity = 8};

      //Act
      double cost = pastry.CalculateCost();

      //Assert
      Assert.AreEqual(12.0, cost, 0.001);
    }
  }
}