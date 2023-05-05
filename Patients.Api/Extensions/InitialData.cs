using Microsoft.EntityFrameworkCore;
using Patients.Api.Data;
using Patients.Api.Models;

namespace Patients.Api.Extensions
{
    public static class InitialData
    {
        public static async void CreateInitialMasters(this ApplicationDbContext context)
        {
            var hasChanges = false;

            //Creación de maestros base para género

            var genderMasterId = "ab5bd865-9a91-4f48-9769-4b325ba54905";
            var femaleId = "f180a9af-e909-4ff9-b00a-9565930edafb";
            var maleId = "f0ace68f-85f1-4e34-9294-3da77beac81a";
            var anotherId = "705a3570-4ef4-447b-8fb0-5dc561ed91de";

            var genderMaster = await context.Masters
                .Include(m => m.DataMasters)
                .FirstOrDefaultAsync(m => m.Id.Equals(genderMasterId));

            if (genderMaster == null)
            {
                genderMaster = new Master()
                {
                    Id = genderMasterId,
                    Description = "Género",
                    Created = DateTime.UtcNow
                };

                context.Masters.Add(genderMaster);
                await context.SaveChangesAsync();
            }

            if (genderMaster.DataMasters == null)
                genderMaster.DataMasters = new List<DataMaster>();

            if (!genderMaster.DataMasters.Any(m => m.Id.Equals(femaleId)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = femaleId,
                    MasterId = genderMaster.Id,
                    Description = "Femenino",
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (!genderMaster.DataMasters.Any(m => m.Id.Equals(maleId)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = maleId,
                    MasterId = genderMaster.Id,
                    Description = "Masculino",
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (!genderMaster.DataMasters.Any(m => m.Id.Equals(anotherId)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = anotherId,
                    MasterId = genderMaster.Id,
                    Description = "Otro",
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (hasChanges)
            {
                await context.SaveChangesAsync();
                hasChanges = false;
            }

            //Creación de maestros base para tipo de usuario

            var userTypesMasterId = "967edfb6-61b5-41fc-8e35-68a2a24bc1fa";
            var patientId = "a89fc0b0-2671-4adb-af41-055ead8de766";
            var doctorId = "38917d23-f34e-4868-8ce3-b1d92f1ef23a";
            var employeeId = "cb0f134a-cc72-40db-b76e-6441dce9cfac";


            var userTypeMaster = await context.Masters
               .Include(m => m.DataMasters)
               .FirstOrDefaultAsync(m => m.Id.Equals(userTypesMasterId));

            if (userTypeMaster == null)
            {
                userTypeMaster = new Master()
                {
                    Id = userTypesMasterId,
                    Description = "Tipo de usuario",
                    Created = DateTime.UtcNow
                };

                context.Masters.Add(userTypeMaster);
                await context.SaveChangesAsync();
            }

            if (userTypeMaster.DataMasters == null)
                userTypeMaster.DataMasters = new List<DataMaster>();

            if (!userTypeMaster.DataMasters.Any(m => m.Id.Equals(patientId)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = patientId,
                    MasterId = userTypesMasterId,
                    Description = "Paciente",
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (!userTypeMaster.DataMasters.Any(m => m.Id.Equals(doctorId)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = doctorId,
                    MasterId = userTypesMasterId,
                    Description = "Doctor",
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (!userTypeMaster.DataMasters.Any(m => m.Id.Equals(employeeId)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = employeeId,
                    MasterId = userTypesMasterId,
                    Description = "Empleado",
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (hasChanges) await context.SaveChangesAsync();
        }
    }
}
