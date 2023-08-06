using Microsoft.AspNetCore.Mvc;

namespace RunGroopWepApp.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
