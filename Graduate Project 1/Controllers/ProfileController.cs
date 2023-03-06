using Graduate_Project_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Graduate_Project_1.Controllers
{
    public class ProfileController : Controller
    {
        private ProfileViewModel ProfileData = new ProfileViewModel();
        public IActionResult Profile()
        {
            ViewData["Profile"] = ProfileData;
            return View();
        }
    }
}
