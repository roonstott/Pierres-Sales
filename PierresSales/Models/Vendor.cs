using System.Collections.Generic;
using System;


namespace PierresSales.Models
{
  public class Vendor
  {
    private static Dictionary<int, Vendor> _clients = new Dictionary<int, Vendor> () {};
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
      _clients[ClientNumber] = this;
    }

    public static Dictionary<int, Vendor> GetClients()
    {
      return _clients;
    }
    public static Vendor FindVendor(int id)
    { 
      return _clients[id];
    }    
  }
}
