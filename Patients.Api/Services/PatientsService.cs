using Microsoft.EntityFrameworkCore;
using Patients.Api.Contracts;
using Patients.Api.Data;
using Patients.Api.Models;

namespace Patients.Api.Services
{
    public class PatientsService : ServiceBase, IPatientsService
    {
        public PatientsService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Patient>> GetPatients()
        {
            return await Context.Patients
                .Include(p=>p.Person)
                .Include(p=>p.Doctor)
                .ToListAsync();
        }

        public async Task<Patient> GetPatient(int personId)
        {
            return await Context.Patients
                .Include(p => p.Person)
                .Include(p => p.Doctor)
                .FirstOrDefaultAsync(p=>p.Id.Equals(personId));
        }

        public async Task CreatePatient(Patient patient)
        {
            patient.Created = DateTime.Now;
            patient.Updated = DateTime.Now;
            Context.Patients.Add(patient);
            await Context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePatient(Patient patient)
        {
            var existingPatient = await Context.Patients.FindAsync(patient.Id);

            if (existingPatient == null) return false;

            existingPatient.DoctorId = patient.DoctorId;
            existingPatient.Condition = patient.Condition;
            existingPatient.User = patient.User;
            existingPatient.Updated = DateTime.UtcNow;

            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePatient(int patientId)
        {
            var existingPerson = await Context.Patients.FindAsync(patientId);

            if (existingPerson == null) return false;

            existingPerson.Updated = DateTime.UtcNow;
            existingPerson.Deleted = DateTime.UtcNow;
            await Context.SaveChangesAsync();
            return true;
        }
    }
}
