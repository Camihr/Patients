using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Patients.Api.Contracts;
using Patients.Api.Data;
using Patients.Api.DTOs;
using Patients.Api.Models;

namespace Patients.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : BaseController
    {
        private readonly IPersonsService personsService;

        public PersonsController(IMapper mapper, IPersonsService personsService) : base(mapper)
        {
            this.personsService = personsService;
        }

        [HttpGet("PatientsEnables")]
        public async Task<IActionResult> PatientsEnables()
        {
            return Ok(new ResponseModel<bool>() { Data = await personsService.PatientsEnables() });
        }

        [HttpGet]
        public async Task<IActionResult> GetPersons()
        {
            return Ok(new ResponseModel<List<Person>>() { Data = await personsService.GetPersons() });
        }

        [HttpGet("PersonsToNewPatient")]
        public async Task<IActionResult> GetPersonsToNewPatient()
        {
            return Ok(new ResponseModel<List<Person>>() { Data = await personsService.GetPersons() });
        }

        [HttpGet("PersonsToExsitingPatient")]
        public async Task<IActionResult> GetPersonsToExsitingPatient()
        {
            return Ok(new ResponseModel<List<Person>>() { Data = await personsService.GetPersons() });
        }

        [HttpGet("{personId}")]
        public async Task<IActionResult> GetPerson(int personId)
        {
            var person = await personsService.GetPerson(personId);

            if (person == null)
            {
                return BadRequest(new ResponseModel<Person>()
                {
                    Message = "El usuario no existe en el sistema"
                });
            }

            return Ok(new ResponseModel<Person>() { Data = person });
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson(Person person)
        {
            await personsService.CreatePerson(person);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePerson(Person person)
        {
            if (await personsService.UpdatePerson(person))
            {
                return Ok();
            }

            return BadRequest(new ResponseModel<Person>()
            {
                Message = "El usuario no existe en el sistema"
            });
        }

        [HttpDelete("{personId}")]
        public async Task<IActionResult> DeletePerson(int personId)
        {
            if (await personsService.DeletePerson(personId))
            {
                return Ok();
            }

            return BadRequest(new ResponseModel<Person>()
            {
                Message = "El usuario no existe en el sistema"
            });
        }
    }
}
