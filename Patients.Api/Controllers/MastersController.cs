using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Patients.Api.Contracts;
using Patients.Api.DTOs;
using Patients.Api.Models;

namespace Patients.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MastersController : BaseController
    {
        private readonly IMastersService mastersService;

        public MastersController(IMapper mapper, IMastersService mastersService) : base(mapper)
        {
            this.mastersService = mastersService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMasters()
        {
            return Ok(new ResponseModel<List<MasterWithDataMasters>>()
            { Data = Mapper.Map<List<MasterWithDataMasters>>(await mastersService.GetMasters()) });
        }
    }
}
