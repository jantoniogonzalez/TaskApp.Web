using Microsoft.AspNetCore.Mvc;

namespace TaskApp.Web.Controllers
{
    public class RolesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
