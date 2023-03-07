using Graduate_Project_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Graduate_Project_1.Controllers
{
    public class ProfileController : Controller
    {
        private Profiles ProfileData = new Profiles();
        public IActionResult Profile()
        {            
            ProfileData.ID = 0;
            ProfileData.Name = "Yasteel";
            ProfileData.Surname = "Gungapursat";
            ProfileData.DOB = new DateTime(1998, 8, 4);
            ProfileData.Age = 24;
            ProfileData.Country = "South Africa";
            ProfileData.City = "Durban";

            ViewData["Profile"] = ProfileData;
            return View();
        }
    }
}
