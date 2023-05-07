using Patients.Api.Models;

namespace Patients.Api.Contracts
{
    public interface IPatientsService
    {
        Task<List<Patient>> GetPatients();
        Task<Patient> GetPatient(int personId);
        Task CreatePatient(Patient patient);
        Task<bool> UpdatePatient(Patient patient);
        Task<bool> DeletePatient(int patientId);
    }
}
