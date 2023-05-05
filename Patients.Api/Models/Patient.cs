using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patients.Api.Models
{
    [Table("Pacientes")]
    public class Patient : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("nmid")]
        public int Id { get; set; }
        
        [Column("nmid_persona")]
        [ForeignKey("persona")]
        public int PersonId { get; set; }
        [Column("persona")]
        public Person Person { get; set; }

        [Column("nmid_medicotra")]
        [ForeignKey("medicotra")]
        public int DoctorId { get; set; }
        [Column("medicotra")]
        public Person Doctor { get; set; }

        [MaxLength(150)]
        [Column("cdusuario")]
        public string User { get; set; }

        [MaxLength(20)]
        [Column("condicion", TypeName = "text")]
        public string Condition { get; set; }
    }
}
