using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*public IActionResult Welcome(String name, int numTimes = 1)
        {
            ViewData["name"] = name;
            ViewData["number"] = numTimes;

            return View();
        }*/
    }
    
    /*public string Index()
    {
        return "This is my default action...";
    }
    */
}

