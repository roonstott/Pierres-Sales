using Microsoft.AspNetCore.Mvc;
using PierresSales.Models;
using System.Collections.Generic;

namespace PierresSales.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New (int id)
    {
      Vendor someVendor = Vendor.FindVendor(id);
      return View(someVendor);
    }
  }
}