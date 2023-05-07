namespace Patients.Api.DTOs
{
    public class MasterWithDataMasters
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public List<DataMasterOfMaster> DataMasters { get; set; }
    }

    public class DataMasterOfMaster
    {
        public string Id { get; set; }
        public string Description { get; set; }
    }
}
