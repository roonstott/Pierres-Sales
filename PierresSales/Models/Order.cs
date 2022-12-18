using System.Collections.Generic;
using System;

namespace PierresSales.Models
{
  public class Order
  {
    public int OrderNumber { get; }
    public bool OrderFulfilled { get; set; }
    public bool OrderPaid { get; set; }
    public string DeliverDay { get; }
    public string DeliverMonth { get; }
    public string SpecialInstructions { get; }    
    public double TotalCost { get; set; }
    public Dictionary<string, double> OrderItems { get; set; }

    public static Dictionary<string, double> PriceList = new Dictionary<string, double> () {{"baguette", 3.25}, {"pastry", 2.00}, {"croissant", 2.50}, {"cookie", 1.50}};
    private static int _orderCounter = 1;

    public Order (string deliverDay, string deliverMonth, string specialInstructions)
    {
      DeliverDay = deliverDay;
      DeliverMonth = deliverMonth;
      string SpecialInstructions = specialInstructions;
      OrderItems = new Dictionary<string, double> () { };
      OrderNumber = _orderCounter; 
      _orderCounter +=1;
      TotalCost = 0;
      OrderFulfilled = false;
      OrderPaid = false;
    }

    public void AddItem(string item, double quantity) 
    {
      OrderItems[item] = quantity;
      CalculateCost();

    }
    public void RemoveItem(string item) 
    {
      OrderItems.Remove(item);
      CalculateCost();
    }
    public void CalculateCost()
    {
      double cost = 0; 
      foreach(KeyValuePair<string, double> item in OrderItems)
      {
        cost += (PriceList[item.Key] * item.Value);
      }
      TotalCost = cost;
    }   
    public void MarkPaid()
    {
      OrderPaid = true;
    }
    public void MarkFulfilled()
    {
      OrderFulfilled = true;
    }
  }
}
