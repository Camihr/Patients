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
    public class PatientsController : BaseController
    {
        private readonly IPatientsService patientsService;

        public PatientsController(IMapper mapper, IPatientsService patientsService) : base(mapper) 
        {
            this.patientsService = patientsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            return Ok(new ResponseModel<List<Patient>>() { Data = await patientsService.GetPatients() });
        }

        [HttpGet("{patientId}")]
        public async Task<IActionResult> GetPatient(int patientId)
        {
            var patient = await patientsService.GetPatient(patientId);

            if (patient == null)
            {
                return BadRequest(new ResponseModel<Patient>()
                {
                    Message = "El paciente no existe en el sistema"
                });
            }

            return Ok(new ResponseModel<Patient>() { Data = patient });
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatient(Patient patient)
        {
            await patientsService.CreatePatient(patient);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePatient(Patient patient)
        {
            if (await patientsService.UpdatePatient(patient))
            {
                return Ok();
            }

            return BadRequest(new ResponseModel<Patient>()
            {
                Message = "El paciente no existe en el sistema"
            });
        }

        [HttpDelete("{patientId}")]
        public async Task<IActionResult> DeletePatient(int patientId)
        {
            if (await patientsService.DeletePatient(patientId))
            {
                return Ok();
            }

            return BadRequest(new ResponseModel<Patient>()
            {
                Message = "El paciente no existe en el sistema"
            });
        }
    }
}
