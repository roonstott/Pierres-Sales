using Microsoft.AspNetCore.Mvc;
using PierresSales.Models;
using System.Collections.Generic;

namespace PierresSales.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
      public ActionResult Index()
      {
        Dictionary<int, Vendor> vendors = Vendor.GetClients();
        return View(vendors);
      }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string address)
    {
      Vendor newVendor = new Vendor(name, address);
      return View("Show", newVendor);
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor someVendor = Vendor.FindVendor(id);
      return View(someVendor);
    }
    
    [HttpPost("/vendors/{vendId}/orders/{ordId}")]
    public ActionResult Update(int vendId, int ordId, int display)
    {
      Vendor someVendor = Vendor.FindVendor(vendId); 
      Order someOrder = someVendor.Orders[ordId];
      if (display == 1) 
      {
        someOrder.MarkFulfilled();
      }
      if (display == 2)
      {
        someOrder.MarkPaid();
      }
      return View("Show", someVendor);
    }
  }
}