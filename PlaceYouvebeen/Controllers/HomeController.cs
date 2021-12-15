using Microsoft.AspNetCore.Mvc;

namespace PlaceYouveBeen.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}