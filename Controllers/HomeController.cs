using Microsoft.AspNetCore.Mvc;

namespace DataNovaDashboard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoadReport(string report)
        {
            switch (report)
            {
                case "Sales":
                    return PartialView("_Sales");
                case "Map":
                    return PartialView("_Map");
                case "Projects":
                    return PartialView("_Projects");
                case "Finance":
                    return PartialView("_Finance");
                default:
                    return Content("Raporttia ei löytynyt.");
            }
        }
    }
}

