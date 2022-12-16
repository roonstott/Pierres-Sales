using System.Collections.Generic;
using System;

namespace PierresSales.Models
{
  public class Order
  {
    public int OrderNumber { get; }
    public string DeliverDate { get; }
    public string SpecialInstructions { get; }    
    public bool OrderFulfilled { get; set; }
    public bool OrderPaid { get; set; }
    public Dictionary<string, int> OrderItems { get; set; }

    private static Dictionary<string, double> _priceList = new Dictionary<string, double> () {{"baguette", 3.25}, {"pastry", 2.00}, {"croissant", 2.50}, {"cookie", 1.50}};
    private static int _orderCounter = 1;

    public Order (string deliverDate, string specialInstructions)
    {
      string DeliverDate = deliverDate;
      string SpecialInstructions = specialInstructions;
      bool OrderFulfilled = false; 
      bool OrderPaid = false;
      OrderItems = new Dictionary<string, int> () { };
      OrderNumber = _orderCounter; 
      _orderCounter +=1; 
    }

    public void AddItem(string item, int quantity) 
    {
      OrderItems[item] = quantity; 
    }
    
  }
}
