using Microsoft.AspNetCore.Mvc;

namespace Group4Flight.Areas.Airlines.Controllers
{
    [Area("Airlines")]
    public class FlightsController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Returns the Dashboard view 
        }

        public IActionResult Manage()
        {
            return Content("Airline Manage Flights Content"); // Returns Content 
        }

        public IActionResult Regulation()
        {
            return Content("Airline Regulation Content"); // Returns Content 
        }
    }
}