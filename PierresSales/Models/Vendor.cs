using System.Collections.Generic;
using System;


namespace PierresSales.Models
{
  public class Vendor
  {
    private static List<Vendor> _clients = new List<Vendor> {};
    public string Name { get; }
    public string Address { get; }
    public int ClientNumber { get; }
    public List<Order> Orders { get; set; }
    private static int _clientCounter = 1;
    public Vendor (string name, string address) 
    {
      Name = name; 
      Address = address;
      ClientNumber = _clientCounter;
      _clientCounter +=1;
      Orders = new List<Order> { };
      _clients.Add(this);
    }

    public static List<Vendor> GetClients()
    {
      return _clients;
    }
    
  }
}
