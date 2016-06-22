using System.Collections.Generic;
using System.Web.Mvc;
using RecipeWarehouse.Models;

namespace RecipeWarehouse.Controllers
{
    public class RecipesController : Controller
    {
        public ActionResult Index()
        {
            return View(new List<Recipe>());
        }
    }
}