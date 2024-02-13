using Microsoft.AspNetCore.Mvc;
using TaskApp.Web.Models;

namespace TaskApp.Web.Controllers
{
    public class PersonController : Controller
    {


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddPersonViewModel viewModel)
        {
            return View();
        }
    }
}
