using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patients.Api.Models
{
    [Table("Maestras")]
    public class Master : ModelBase
    {
        [Key]
        [MaxLength(150)]
        [Column("nmmaestro")]
        public string Id { get; set; }

        [MaxLength(100)]
        [Column("dsmaestro")]
        public string Description { get; set; }

        public List<DataMaster> DataMasters { get; set; }
    }
}
