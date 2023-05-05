using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patients.Api.Models
{
    [Table("Personas")]
    public class Person : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("nmid")]
        public int Id { get; set; }

        [MaxLength(20)]
        [Column("cddocument")]
        public string Document { get; set; }

        [MaxLength(60)]
        [Column("dsnombres")]
        public string Names { get; set; }
        
        [MaxLength(60)]
        [Column("dsapellidos")]
        public string LastNames { get; set; }

        [Column("fenacimiento", TypeName = "date")]
        public DateTime Born { get; set; }

        [MaxLength(150)]
        [Column("cdusuario")]
        public string User { get; set; }

        [MaxLength(200)]
        [Column("dsdireccion")]
        public string Address { get; set; }

        [MaxLength(500)]
        [Column("dsphoto")]
        public string Photo { get; set; }

        [MaxLength(20)]
        [Column("cdtelefono_fijo")]
        public string Phone { get; set; }

        [MaxLength(20)]
        [Column("cdtelefono_movil")]
        public string CellPhone { get; set; }

        [MaxLength(200)]
        [Column("dsemail")]
        public string Email { get; set; }

        public List<PersonDataMaster> PersonsDataMasters { get; set; }
    }
}
