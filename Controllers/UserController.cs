using Microsoft.AspNetCore.Mvc;
using ToDo.DataAcces;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult ViewTasks()
        {
            if(HttpContext.Session.GetString("id") == null)
            {
                return RedirectToAction("GetLoginForm", "Home");
            }
            string id = HttpContext.Session.GetString("id");
            DbHelper dbHelper = new DbHelper();
            ViewModelFactory viewModelFactory = new ViewModelFactory(dbHelper);
            TaskViewModel tasks = viewModelFactory.GetTaskVieModel(id);
            
            return View(tasks);
        }
    }
}
