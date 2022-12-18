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
      Order newOrder1 = new Order("3", "1", "leave on porch");
      Assert.AreEqual(typeof(Order), newOrder1.GetType());       
    }
    [TestMethod]
    public void Constructor_AssignsUniqueId_Int()
    {
      Order newOrder1 = new Order("3", "1", "leave on porch");
      Order newOrder2 = new Order("1", "2", "extra chocolate");
      int result1 = newOrder1.OrderNumber;
      int result2 = newOrder2.OrderNumber;
      Assert.AreEqual(2, result1); 
      Assert.AreEqual(3, result2);
    }
    [TestMethod]
    public void AddItem_AddsOrderItem_OrderItemsDictionaryElement()
    {
      Order newOrder1 = new Order("3", "1", "leave on porch");
      newOrder1.AddItem("croissant", 3); 
      double result = newOrder1.OrderItems["croissant"];
      Assert.AreEqual(3, result); 
    }
    [TestMethod] 
    public void RemoveItem_RemovesOrderItem_OrderItemsDictionary()
    {
      Order newOrder1 = new Order("3", "1", "leave on porch");
      newOrder1.AddItem("croissant", 3);
      newOrder1.AddItem("cookie", 15);
      newOrder1.AddItem("pastry", 25);
      newOrder1.RemoveItem("cookie"); 
      int result = newOrder1.OrderItems.Count;
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void TotalCost_CalculatesTotalCostOfOrder_Double()
    {
      Order newOrder1 = new Order("3", "1", "leave on porch");
      newOrder1.AddItem("croissant", 3);
      newOrder1.AddItem("cookie", 15);
      newOrder1.AddItem("pastry", 25);
      double result = newOrder1.TotalCost;
      Assert.AreEqual(80, result);
    }
    [TestMethod]
    public void MarkPaid_ChangesOrderPaidBoolToTrue_Bool()
    {
      Order newOrder1 = new Order("3", "1", "leave on porch");
      newOrder1.MarkPaid(); 
      bool result = newOrder1.OrderPaid;
      Assert.AreEqual(result, true);
    }
    [TestMethod]
    public void MarkFulfilled_ChangesOrderFulfilledBoolToTrue_Bool()
    {
      Order newOrder1 = new Order("3", "1", "leave on porch");
      newOrder1.MarkFulfilled(); 
      bool result = newOrder1.OrderFulfilled;
      Assert.AreEqual(result, true);
    }
  }
}