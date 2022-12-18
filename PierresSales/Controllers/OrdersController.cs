using Microsoft.AspNetCore.Mvc;
using PierresSales.Models;
using System.Collections.Generic;

namespace PierresSales.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders")]
    public ActionResult Index (int Id)
    {
      Vendor someVendor = Vendor.FindVendor(Id);
      return View(someVendor);
    }


    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New (int Id)
    {
      Vendor someVendor = Vendor.FindVendor(Id);
      return View(someVendor);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create (int Id, string baguette, string pastry, string croissant, string cookie, string deliverDay, string deliverMonth, string specialInstructions)
    {
      Vendor someVendor = Vendor.FindVendor(Id);
      Order newOrder = new Order(deliverDay, deliverMonth, specialInstructions);
      newOrder.AddItem("baguette", double.Parse(baguette));
      newOrder.AddItem("pastry", double.Parse(pastry));
      newOrder.AddItem("croissant", double.Parse(croissant));
      newOrder.AddItem("cookie", double.Parse(cookie));
      someVendor.AddOrder(newOrder);
      return View("Index", someVendor);
    }

    [HttpGet("/vendors/all/orders/{display}")]
    public ActionResult IndexAll (int display)
    {
      return View(display);
    }

    [HttpPost("/vendors/all/orders/{ordId}")]
    public ActionResult Update (int display, int vendId, int ordId)
    {
      Vendor someVendor = Vendor.FindVendor(vendId); 
      Order someOrder = someVendor.Orders[ordId];
      if (display == 2) 
        {
          someOrder.MarkFulfilled();
        }
      if (display == 3)
        {
          someOrder.MarkPaid();
        }
      
      return View("IndexAll", display);      
    }

  }
}