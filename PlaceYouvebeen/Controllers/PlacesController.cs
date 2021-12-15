using Microsoft.AspNetCore.Mvc;
using PlaceYouveBeen.Models;
using System.Collections.Generic;

namespace PlaceYouveBeen.Controllers
{
    public class PlacesController : Controller
    {
      [HttpGet("/places")]
      public ActionResult Index()
      {
        List<Place> allPlaces = Place.GetAll();
        return View(allPlaces);
      }

      [HttpGet("/places/new")]
      public ActionResult New()
      {
        return View();
      }

      [HttpPost("/places")]  //POST method sends data to the serve take data from user
      public ActionResult Create(string cityName)
      {
        Place myPlaces = new Place(cityName);
        return RedirectToAction("Index");
      }

      [HttpPost("/places/delete")]
      public ActionResult DeleteAll()
      {
        Place.ClearAll();
        return View();
      }
  
    }
}