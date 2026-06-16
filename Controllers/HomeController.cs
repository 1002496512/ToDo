using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDo.Models;
using ToDo.DataAcces;


namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult ViewHomePage()
        {

            return View();
        }

        public IActionResult GetLoginForm()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(string nickname, string password)
        {
            DbHelper dbHelper = new DbHelper();
            ViewModelFactory viewModelFactory = new ViewModelFactory(dbHelper);
            string id = viewModelFactory.LoginUser(nickname, password);
            if(id==null)
            {
                ViewBag.LoginError = true;
                return View("GetLoginForm");
            }
            HttpContext.Session.SetString("id", id);
            return RedirectToAction("ViewTasks", "User");
        }


    }
}
