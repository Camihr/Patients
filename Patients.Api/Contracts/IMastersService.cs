using Patients.Api.DTOs;
using Patients.Api.Models;

namespace Patients.Api.Contracts
{
    public interface IMastersService
    {
        Task<List<Master>> GetMasters();
    }
}
