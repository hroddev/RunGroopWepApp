using Microsoft.AspNetCore.Mvc;

namespace RunGroopWepApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
