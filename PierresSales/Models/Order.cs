using System.Collections.Generic;
using System;

namespace PierresSales.Models
{
  public class Order
  {
    public int OrderNumber { get; }
    public int[] DeliverDate { get; }
    public string SpecialInstructions { get; }    
    public bool OrderFulfilled { get; set; }
    public bool OrderPaid { get; set; }
    public Dictionary<string, double> OrderItems { get; set; }

    private static Dictionary<string, double> _priceList = new Dictionary<string, double> () {{"baguette", 3.25}, {"pastry", 2.00}, {"croissant", 2.50}, {"cookie", 1.50}};
    private static int _orderCounter = 1;

    public Order (int deliverDay, int deliverMonth, string specialInstructions)
    {
      int[] DeliverDate = {deliverMonth, deliverDay};
      string SpecialInstructions = specialInstructions;
      bool OrderFulfilled = false; 
      bool OrderPaid = false;
      OrderItems = new Dictionary<string, double> () { };
      OrderNumber = _orderCounter; 
      _orderCounter +=1; 
    }

    public void AddItem(string item, int quantity) 
    {
      OrderItems[item] = quantity; 
    }
    public void RemoveItem(string item) 
    {
      OrderItems.Remove(item);
    }
    public double TotalCost()
    {
      double cost = 0; 
      foreach(KeyValuePair<string, double> item in OrderItems)
      {
        cost += (_priceList[item.Key] * item.Value);
      }
      return cost;
    }
    
  }
}
