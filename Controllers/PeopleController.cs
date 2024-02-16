using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskApp.Web.Data;
using TaskApp.Web.Models;
using TaskApp.Web.Models.Entities;

namespace TaskApp.Web.Controllers
{
    public class PeopleController : Controller
    {

        private readonly ApplicationDbContext dbContext;

        public PeopleController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPersonViewModel viewModel)
        {
            var person = new Person
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                RoleId = viewModel.RoleId,
            };


            await dbContext.People.AddAsync(person);
            await dbContext.SaveChangesAsync();

            
            return RedirectToAction("List", "People");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var people = await dbContext.People.ToListAsync();

            return View(people);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var person = await dbContext.People.FindAsync(id);

            return View(person);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Person person)
        {
            

            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "People");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var person = await dbContext.People.FindAsync(id);

            return View(person);
        }
    }
}
