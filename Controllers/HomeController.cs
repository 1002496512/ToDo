using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult ViewHomePage()
        {

            return View();
        }

      
    }
}
