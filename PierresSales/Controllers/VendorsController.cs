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
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor someVendor = Vendor.FindVendor(id);
      return View(someVendor);
    }
    

  }
}