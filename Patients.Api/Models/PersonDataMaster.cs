using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patients.Api.Models
{
    [Table("PersonasDataMaestras")]
    public class PersonDataMaster
    {
        [Column("nmid_persona")]
        [ForeignKey("persona")]
        public int PersonId { get; set; }
        [Column("persona")]
        public Person Person { get; set; }

        [ForeignKey("dato")]
        [MaxLength(150)]
        [Column("nmdato")]
        public string DataMasterId { get; set; }
        [Column("dato")]
        public DataMaster DataMaster { get; set; }
    }
}
