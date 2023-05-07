using AutoMapper;
using Patients.Api.Data;

namespace Patients.Api.Services
{
    public class ServiceBase
    {
        public ServiceBase(ApplicationDbContext context)
        {
            Context = context;
        }

        public ApplicationDbContext Context { get; }
    }
}
