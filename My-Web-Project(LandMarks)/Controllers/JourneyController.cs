
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MMy_Web_Project_LandMarks_.Controllers
{
    [Authorize]
    public class JourneyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
