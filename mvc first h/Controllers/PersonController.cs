using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace mvc_first_h.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return  View("~/Views/Home/Index.cshtml"); 
        }
        
        public IActionResult Hobby()
        {
            return View("~/Views/Home/Hobby.cshtml");
        }
    }
}
