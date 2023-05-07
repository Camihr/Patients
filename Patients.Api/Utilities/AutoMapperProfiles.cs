using AutoMapper;
using Patients.Api.DTOs;
using Patients.Api.Models;

namespace WebAPIAutores.Utilities
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Master, MasterWithDataMasters>();
            CreateMap<DataMaster, DataMasterOfMaster>();
        }
    }
}
