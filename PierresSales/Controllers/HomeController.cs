using Microsoft.AspNetCore.Mvc;

namespace PierresSales.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}