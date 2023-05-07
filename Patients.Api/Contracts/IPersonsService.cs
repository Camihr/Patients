using Patients.Api.Models;

namespace Patients.Api.Contracts
{
    public interface IPersonsService
    {
        Task CreatePerson(Person person);
        Task<bool> DeletePerson(int personId);
        Task<Person> GetPerson(int personId);
        Task<List<Person>> GetPersons();
        Task<List<Person>> GetPersonsToExsitingPatient();
        Task<List<Person>> GetPersonsToNewPatient();
        Task<bool> PatientsEnables();
        Task<bool> UpdatePerson(Person person);
    }
}
