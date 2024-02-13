using Microsoft.AspNetCore.Mvc;

namespace TaskApp.Web.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
