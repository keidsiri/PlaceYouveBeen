using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace PlaceYouveBeen.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Item starterItem = new Item("Add first item to To Do List");
      return View(starterItem);
    }

  }
}