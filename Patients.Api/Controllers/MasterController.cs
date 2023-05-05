using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patients.Api.Data;
using Patients.Api.Models;

namespace Patients.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : Controller
    {
        private readonly ApplicationDbContext context;

        public MasterController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMasters()
        {
            var generMaster = await context.Masters
                .FirstOrDefaultAsync();

            return Ok(generMaster);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMaster()
        {
            var master = new Master()
            {
                Id = "a2d8ae4f-2a63-4904-a0d0-87bf2b534b14",
                Description = "Tipo de usuario",
                Created = DateTime.UtcNow
            };

            context.Masters.Add(master);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
