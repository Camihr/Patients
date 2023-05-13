using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Patients.Api.Contracts;
using Patients.Api.Data;
using Patients.Api.Models;
using Patients.Api.Utilities;
using System;

namespace Patients.Api.Services
{
    public class PersonsService : ServiceBase, IPersonsService
    {
        public PersonsService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> PatientsEnables()
        {
            return await Context.Persons.AnyAsync(u => u.UserType.Equals(Consts.DOCTOR))
                 && await Context.Persons.AnyAsync(u => u.UserType.Equals(Consts.PATIENT));
        }

        public async Task<List<Person>> GetPersons()
        {
            return await Context.Persons.ToListAsync();
        }

        public async Task<List<Person>> GetPersonsToNewPatient()
        {
            return await Context.Persons
                .Where(p=> !p.UserType.Equals(Consts.EMPLOYEE))
                .ToListAsync();
        }

        public async Task<List<Person>> GetPersonsToExsitingPatient()
        {
            return await Context.Persons
                .Where(p => p.UserType.Equals(Consts.DOCTOR))
                .ToListAsync();
        }

        public async Task<Person> GetPerson(int personId)
        {
            return await Context.Persons.FindAsync(personId);
        }

        public async Task CreatePerson(Person person)
        {
            person.Created = DateTime.Now;
            person.Updated = DateTime.Now;
            Context.Persons.Add(person);
            await Context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePerson(Person person)
        {
            var existingPerson = await Context.Persons.FindAsync(person.Id);

            if (existingPerson == null) return false;

            existingPerson.Document = person.Document;
            existingPerson.Names = person.Names;
            existingPerson.LastNames = person.LastNames;
            existingPerson.Born = person.Born;
            existingPerson.Gender = person.Gender;
            existingPerson.User = person.User;
            existingPerson.Address = person.Address;
            existingPerson.Photo = person.Photo;
            existingPerson.Phone = person.Phone;
            existingPerson.CellPhone = person.CellPhone;
            existingPerson.Email = person.Email;
            existingPerson.Updated = DateTime.UtcNow;

            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePerson(int personId)
        {
            var existingPerson = await Context.Persons.FindAsync(personId);

            if (existingPerson == null) return false;

            existingPerson.Updated = DateTime.UtcNow;
            existingPerson.Deleted = DateTime.UtcNow;
            await Context.SaveChangesAsync();
            return true;
        }
    }
}
