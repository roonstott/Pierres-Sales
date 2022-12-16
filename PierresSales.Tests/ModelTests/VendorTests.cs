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
      Dictionary<int, Vendor> result = Vendor.GetClients();
      Assert.AreEqual(newVendor.Name, result[2].Name); 
    }
    [TestMethod]
    public void FindVendor_ReturnsAVendorBasedOnId_Vendor()
    {
      Vendor newVendor1 = new Vendor("Robert", "5080 NE 56th Ave");
      Vendor newVendor2 = new Vendor("Allie", "5305 NE 28th Ave");
      Vendor newVendor3 = new Vendor("Hunter", "1023 SE 44th Ave");
      Console.WriteLine(newVendor3.ClientNumber);
      Vendor result = Vendor.FindVendor(5);
      Assert.AreEqual(newVendor3.Name, result.Name);
    }
    [TestMethod]
    public void AddOrder_AddsAnOrderToOrdersDictionary_Void()
    {
      Vendor newVendor1 = new Vendor("Robert", "5080 NE 56th Ave");
      Order newOrder1 = new Order(3, 1, "leave on porch");
      newOrder1.AddItem("croissant", 3);
      newOrder1.AddItem("cookie", 15);
      newOrder1.AddItem("pastry", 25);
      newVendor1.AddOrder(newOrder1);
      int orderId = newOrder1.OrderNumber;
      double cost = newVendor1.Orders[orderId].TotalCost;
      Assert.AreEqual(80, cost);       
    }
  }
}