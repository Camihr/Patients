using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Patients.Api.Contracts;
using Patients.Api.Data;
using Patients.Api.DTOs;
using Patients.Api.Models;

namespace Patients.Api.Services
{
    public class MastersService : ServiceBase, IMastersService
    {
        public MastersService(ApplicationDbContext context) : base(context) 
        {
        }

        public async Task<List<Master>> GetMasters()
        {
            var genersMaster = await Context.Masters
                .Include(m => m.DataMasters)
                .ToListAsync();

            return genersMaster;
        }
    }
}
