using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Patients.Api.Models
{
    [Table("DataMaestra")]
    public class DataMaster : ModelBase
    {
        [Key]
        [MaxLength(150)]
        [Column("nmdato")]
        public string Id { get; set; }

        [ForeignKey("maestro")]
        [MaxLength(150)]
        [Column("nmmaestro")]
        public string MasterId { get; set; }
        [Column("maestro")]
        public Master Master { get; set; }

        [MaxLength(100)]
        [Column("dsdato")]
        public string Description { get; set; }

        public List<PersonDataMaster> PersonsDataMasters { get; set; }
    }
}
