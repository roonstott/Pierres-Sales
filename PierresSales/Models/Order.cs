using System.Collections.Generic;
using System;

namespace PierresSales.Models
{
  public class Order
  {
    public int OrderNumber { get; }
    public Dictionary<string, int> DeliverDate { get; }
    public string SpecialInstructions { get; }    
    public double TotalCost { get; set; }
    public Dictionary<string, double> OrderItems { get; set; }

    private static Dictionary<string, double> _priceList = new Dictionary<string, double> () {{"baguette", 3.25}, {"pastry", 2.00}, {"croissant", 2.50}, {"cookie", 1.50}};
    private static int _orderCounter = 1;

    public Order (int deliverDay, int deliverMonth, string specialInstructions)
    {
      Dictionary<string, int> DeliverDate = new Dictionary<string, int>() {{"month", deliverMonth}, {"day", deliverDay}};
      string SpecialInstructions = specialInstructions;
      OrderItems = new Dictionary<string, double> () { };
      OrderNumber = _orderCounter; 
      _orderCounter +=1;
      TotalCost = 0; 
    }

    public void AddItem(string item, int quantity) 
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
        cost += (_priceList[item.Key] * item.Value);
      }
      TotalCost = cost;
    }    
  }
}
