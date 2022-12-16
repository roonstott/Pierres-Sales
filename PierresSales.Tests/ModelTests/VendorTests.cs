using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresSales.Models;
using System;

namespace PierresSales.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void Constructor_CreatesInstanceOfVendorClass_Vendor()
    {
      Vendor newVendor = new Vendor("Robert", "5080 NE 56th Ave");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetClients_ReturnsClients_List()
    {
      Vendor newVendor = new Vendor("Robert", "5080 NE 56th Ave");
      List<Vendor> result = Vendor.GetClients();
      Assert.AreEqual(newVendor, result[0]); 
    }
  }
}