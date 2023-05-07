using Microsoft.EntityFrameworkCore;
using Patients.Api.Data;
using Patients.Api.Models;
using Patients.Api.Utilities;

namespace Patients.Api.Extensions
{
    public static class InitialData
    {
        public static async void CreateInitialMasters(this ApplicationDbContext context)
        {
            var hasChanges = false;

            //Creación de maestros base para género

            var genderMaster = await context.Masters
                .Include(m => m.DataMasters)
                .FirstOrDefaultAsync(m => m.Id.Equals(Consts.MASTER_GENDER_ID));

            if (genderMaster == null)
            {
                genderMaster = new Master()
                {
                    Id = Consts.MASTER_GENDER_ID,
                    Description = Consts.GENDER,
                    Created = DateTime.UtcNow
                };

                context.Masters.Add(genderMaster);
                await context.SaveChangesAsync();
            }

            if (genderMaster.DataMasters == null)
                genderMaster.DataMasters = new List<DataMaster>();

            if (!genderMaster.DataMasters.Any(m => m.Id.Equals(Consts.DATA_FAMELE_ID)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = Consts.DATA_FAMELE_ID,
                    MasterId = Consts.MASTER_GENDER_ID,
                    Description = Consts.FAMELE,
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (!genderMaster.DataMasters.Any(m => m.Id.Equals(Consts.DATA_MALE_ID)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = Consts.DATA_MALE_ID,
                    MasterId = Consts.MASTER_GENDER_ID,
                    Description = Consts.MALE,
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (!genderMaster.DataMasters.Any(m => m.Id.Equals(Consts.DATA_ANOTHER_ID)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = Consts.DATA_ANOTHER_ID,
                    MasterId = Consts.MASTER_GENDER_ID,
                    Description = Consts.ANOTHER,
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

            var userTypeMaster = await context.Masters
               .Include(m => m.DataMasters)
               .FirstOrDefaultAsync(m => m.Id.Equals(Consts.MASTER_USER_TYPES_ID));

            if (userTypeMaster == null)
            {
                userTypeMaster = new Master()
                {
                    Id = Consts.MASTER_USER_TYPES_ID,
                    Description = Consts.USER_TYPE,
                    Created = DateTime.UtcNow
                };

                context.Masters.Add(userTypeMaster);
                await context.SaveChangesAsync();
            }

            if (userTypeMaster.DataMasters == null)
                userTypeMaster.DataMasters = new List<DataMaster>();

            if (!userTypeMaster.DataMasters.Any(m => m.Id.Equals(Consts.DATA_PATIENT_ID)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = Consts.DATA_PATIENT_ID,
                    MasterId = Consts.MASTER_USER_TYPES_ID,
                    Description = Consts.PATIENT,
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (!userTypeMaster.DataMasters.Any(m => m.Id.Equals(Consts.DATA_DOCTOR_ID)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = Consts.DATA_DOCTOR_ID,
                    MasterId = Consts.MASTER_USER_TYPES_ID,
                    Description = Consts.DOCTOR,
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (!userTypeMaster.DataMasters.Any(m => m.Id.Equals(Consts.DATA_EMPLOYEE_ID)))
            {
                var dataMaster = new DataMaster()
                {
                    Id = Consts.DATA_EMPLOYEE_ID,
                    MasterId = Consts.MASTER_USER_TYPES_ID,
                    Description = Consts.EMPLOYEE,
                    Created = DateTime.UtcNow
                };

                context.DataMasters.Add(dataMaster);
                hasChanges = true;
            }

            if (hasChanges) await context.SaveChangesAsync();
        }
    }
}
