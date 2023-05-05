using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Patients.Api.Models;
using System.Reflection.Emit;

namespace Patients.Api.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PersonDataMaster>()
               .HasKey(x => new { x.PersonId, x.DataMasterId });

            builder.Entity<PersonDataMaster>()
                .HasOne(x => x.Person)
                .WithMany(x => x.PersonsDataMasters)
                .HasForeignKey(x => x.PersonId);

            builder.Entity<PersonDataMaster>()
                .HasOne(x => x.DataMaster)
                .WithMany(x => x.PersonsDataMasters)
                .HasForeignKey(x => x.DataMasterId);

            builder.Entity<Person>()
                .HasIndex(x => x.Document)
                .IsUnique(false);

            builder.Entity<Person>()
               .HasIndex(x => x.Names)
               .IsUnique(false);

            builder.Entity<Person>()
               .HasIndex(x => x.Born)
               .IsUnique(false);

            builder.Entity<Person>().HasQueryFilter(p => p.Deleted == null);
            builder.Entity<Patient>().HasQueryFilter(p => p.Deleted == null);
            builder.Entity<Master>().HasQueryFilter(p => p.Deleted == null);
            builder.Entity<DataMaster>().HasQueryFilter(p => p.Deleted == null);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<DataMaster> DataMasters { get; set; }
        public DbSet<PersonDataMaster> PersonsDataMasters { get; set; }
    }
}
