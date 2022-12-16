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
  }
}