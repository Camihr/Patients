using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Patients.Api.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(IMapper mapper)
        {
            Mapper = mapper;
        }

        public IMapper Mapper { get; }
    }
}
