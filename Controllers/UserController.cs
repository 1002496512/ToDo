using Microsoft.AspNetCore.Mvc;

namespace ToDo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult ViewTasks()
        {
            return View();
        }
    }
}
