using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patients.Api.Data;
using Patients.Api.Models;

namespace Patients.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext context;

        public PersonController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersons()
        {
            var persons = await context.Persons
                .FirstOrDefaultAsync();

            return Ok(persons);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson()
        {
            var person = new Person()
            {
                Names = "Juan Almeda",
                Created = DateTime.UtcNow
            };

            context.Persons.Add(person);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
