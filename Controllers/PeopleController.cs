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

        [HttpPost]
        public async Task<IActionResult> Edit(Person viewModel)
        {
            Guid personId = viewModel.Id;
            // Find in db person
            var person = await dbContext.People.FindAsync(personId);

            // Edit person details
            if (person is not null)
            {
                if (!String.IsNullOrEmpty(viewModel.Name))
                {
                    person.Name = viewModel.Name;
                }
                person.Email = viewModel.Email;
                person.Phone = viewModel.Phone;
            }

            // Save the changes made
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "People");
        }


        [HttpPost]
        public async Task<IActionResult> Delete(Person viewModel)
        {
            var person = await dbContext.People.FindAsync(viewModel.Id);

            if (person is not null)
            {
                dbContext.People.Remove(person);
            }

            await dbContext.SaveChangesAsync();
            return RedirectToAction("List", "People");
        }
    }
}
