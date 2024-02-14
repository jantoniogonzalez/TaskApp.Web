using Microsoft.AspNetCore.Mvc;

namespace TaskApp.Web.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
