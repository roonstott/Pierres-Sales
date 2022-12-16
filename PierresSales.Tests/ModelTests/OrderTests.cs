using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresSales.Models;
using System;

namespace PierresSales.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Constructor_CreatesInstanceOfClass_Order()
    {
      Order newOrder1 = new Order("March 1st", "leave on porch");
      Assert.AreEqual(typeof(Order), newOrder1.GetType());       
    }
    [TestMethod]
    public void Constructor_AssignsUniqueId_Int()
    {
      Order newOrder1 = new Order("March 1st", "leave on porch");
      Order newOrder2 = new Order("Janurary 2nd", "extra chocolate");
      int result1 = newOrder1.OrderNumber;
      int result2 = newOrder2.OrderNumber;
      Assert.AreEqual(2, result1); 
      Assert.AreEqual(3, result2);
    }
  }
}