using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      // [HttpGet("/items/new")]
      // public ActionResult New()
      // {
      //   return View();
      // }

    }
}